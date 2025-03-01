using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassesDemo
{
    internal class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public Car(int id, string Make, string Model, int Year)
        {
            this.Id = id;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }

        public string ToString()
        {
            return $"Car({Id}: {Make}, {Model}, {Year})";
        }
    }
}
