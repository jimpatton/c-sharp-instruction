using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_ContactList
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }

        public Contact() { }

        public Contact(string FirstName, string LastName, string Email, string Phone) 
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        public string DisplayContact()
        {
            return $@"
        --------------------------------------
        ----Current Contact-------------------
        Name:           {FirstName} {LastName}
        Email Address:  {Email}
        Phone Number:   {Phone}
        --------------------------------------
        ";
        }       
    }
}
