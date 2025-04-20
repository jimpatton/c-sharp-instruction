using System.Security.Cryptography.X509Certificates;

namespace ch14PersonMgr.Model
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public virtual string ToString()
        {
            return $"Name: {FirstName} {LastName}\n";
        }


    }
}
