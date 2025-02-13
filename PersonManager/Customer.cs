namespace PersonManager
{
    public class Customer : Person
    {
        public string CustomerNbr { get; set; }

        public Customer(string firstName, string lastName, string customerNbr) :
            base(firstName, lastName)
        { 
            this.CustomerNbr = customerNbr; 
        }
        public string ToString()
        {
            return $"{base.ToString()}{CustomerNbr}";
        }




    }
}

