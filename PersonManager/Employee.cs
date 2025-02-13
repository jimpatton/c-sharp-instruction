using System.Security.Cryptography.X509Certificates;

namespace PersonManager
{
    public class Employee : Person
    {
        public string Ssn { get; set; }

        public Employee(string firstName, string lastName, string ssn) :
            base(firstName, lastName)
        {
            this.Ssn = ssn;
        }
        public string ToString()
        {
            return $"{base.ToString()}{Ssn}";
        }
    }
}
