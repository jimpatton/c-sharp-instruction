namespace PersonManager
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string ToString()
        {
            return $"Name: {FirstName}{LastName}";
        }


    }
}
