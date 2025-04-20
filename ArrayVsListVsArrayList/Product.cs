using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsListVsArrayList
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string code, string description, decimal price)
        {
            this.ProductId = productId;
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Product: {ProductId} | {Code} | {Description} | {Price:c}";
        }

    }
}
