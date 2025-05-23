﻿using System.Net.NetworkInformation;
using System.Xml.Linq;
using ConsoleLibrary;

namespace ch18LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("CH 18 LINQ!\n");


            //pg 581
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumberQuery = from number in numbers
                                  where number % 2 == 0
                                  orderby number descending
                                  select number;
            //execute the query - loop through results and store in a string
            string evenNumbers = "";
            foreach (var nbr in evenNumberQuery)
            {
                evenNumbers += nbr + " ";
            }
            MyConsole.PrintLine(evenNumbers);

            //pg 583
            decimal[] salesTotals = { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals
                            select sales;
            decimal sum = 0.0m;
            foreach (var sales in salesTotals)
            {
                sum += sales;
            }
            MyConsole.PrintLine("sales = " + sum.ToString());

            //pg 583 Invoices List
            List<Invoice> invoicesList = InvoiceDB.GetInvoices();
            //foreach (var invoice in invoicesList) { 
            //    MyConsole.PrintLine(invoice.ToString());
            //}
            var invoices = from invoice in invoicesList
                           select invoice;
            foreach (var invoice in invoices)
            {
                MyConsole.PrintLine(invoice.ToString());
            }

            //pg 585
            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;
            string salesDisplay = "";
            foreach (var sales in salesList)
                salesDisplay += sales.ToString("c") + "|";
                MyConsole.PrintLine(salesDisplay);

            MyConsole.PrintLine("--------Invoices with totals over $150--------");
            invoices = from invoice in invoicesList
                       where invoice.InvoiceTotal >150
                       select invoice;
            string invoiceDisplay = "";
                foreach (var invoice in invoices)
            {
                invoiceDisplay += invoice.InvoiceTotal.ToString("c") + "|";
            }
                MyConsole.PrintLine(invoiceDisplay);


            MyConsole.PrintLine("++++++Join in LINQ+++++++");
                List<Customer> customersList = CustomerDB.GetCustomers();

            var invoices2 = from invoice in invoicesList
                       join customer in customersList
                       on invoice.CustomerID equals customer.CustomerID
                       where invoice.InvoiceTotal > 150
                       orderby customer.Name, invoice.InvoiceTotal descending
                       select new { customer.Name, invoice.InvoiceTotal };
            invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
            foreach (var i in invoices2) {
                invoiceDisplay += i.Name + "\t\t" + i.InvoiceTotal.ToString("c") + "\n";
            }
            MyConsole.PrintLine(invoiceDisplay);


            //pg 593 - extention methods
            //list of invoicestotal > than 150 ordered by customerid, then by invoiceTotal descending
            var invoices3 = invoicesList.
                Where(i => i.InvoiceTotal > 150).
                OrderBy(i => i.CustomerID).
                ThenByDescending(i => i.InvoiceTotal).
                Select(i => new { i.CustomerID, i.InvoiceTotal });

            foreach (var i in invoices3) { 
            MyConsole.PrintLine($"{i.CustomerID},{i.InvoiceTotal:c}");
            }



            MyConsole.PrintLine("\nBye");
        }
    }
}
