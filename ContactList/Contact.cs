namespace ContactList
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact()
        { }
        public Contact(string FirstName, string LastName, string Email, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }
        public string DisplayContact()
        {
            string displayStr = "-----------------------------------\n";
            displayStr += "----Current Contact ---------------\n";
            displayStr += "-----------------------------------\n";
            displayStr +=($"Name:\t\t {FirstName} {LastName} \nEmailaddress:\t {Email} \nPhone number:\t {Phone}");
            displayStr += "\n-----------------------------------\n";
            return displayStr;
        }



    }
}
