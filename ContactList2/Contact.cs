namespace ContactList2
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact() { }

        public Contact(string FirstName, string LastName, string Email, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
                public string DisplayContact() 
        {
            string displayStr = "-------------------------------\n";
            displayStr += "----Current Contact------------\n";
            displayStr += "-------------------------------\n";
            displayStr += $"Name:\t\t {FirstName} {LastName}\nEmail Address:\t {Email} \nPhone number:\t {PhoneNumber}";
            displayStr += "\n-------------------------------\n";
            return displayStr;
                        
        }

    }
}
