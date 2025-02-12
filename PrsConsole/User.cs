
namespace PrsConsole
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Reviewer { get; set; }
        public string Admin { get; set; }

        public User()
        {
        }

        public User(int Id, string UserName, string Password, string FirstName, string LastName, string PhoneNumber, string Email, string Reviewer, string Admin)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Reviewer = Reviewer;
            this.Admin = Admin;
        }

        public string ToString()
        {
            return $"User({Id}: {UserName}, {Password}, {FirstName}, {LastName}, {PhoneNumber}, {Email}, {Reviewer}, {Admin})";
        }






    }
}
