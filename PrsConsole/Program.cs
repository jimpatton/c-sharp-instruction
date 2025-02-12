using ConsoleLibrary;
namespace PrsConsole
{
    internal class Program
    {
        static List<User> Users = new List<User>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("PrsConsole!");
            User newUser = new User();
            newUser.Id = 1;
            newUser.UserName = "SarlacSlayer";
            newUser.Password = "BountyHunt";
            newUser.FirstName = "Boba";
            newUser.LastName = "Fett";
            newUser.PhoneNumber = "513-555-5555";
            newUser.Email = "boba@slave1.com";
            newUser.Reviewer = "No";
            newUser.Admin = "No";
            Users.Add(newUser);

            string choice = "y";
            while (choice == "y")
            {
                int Id = MyConsole.PromptInt("User Id: ");
                string UserName = MyConsole.PromptString("Username: ");
                string Password = MyConsole.PromptString("Password: ");
                string FirstName = MyConsole.PromptString("First Name: ");
                string LastName = MyConsole.PromptString("Last Name: ");
                string PhoneNumber = MyConsole.PromptString("Phone number: ");
                string Email = MyConsole.PromptString("Email: ");
                string Reviewer = MyConsole.PromptString("Reviewer: ");
                string Admin = MyConsole.PromptString("Amin: ");
                newUser = new User(Id, UserName, Password, FirstName, LastName, PhoneNumber, Email, Reviewer, Admin);
                Users.Add(newUser);
                choice = MyConsole.PromptString("\nAdd another user? (y/n)");

            }
            MyConsole.PrintLine("========== Users ==========");
            foreach (User user in Users) { 
            MyConsole.PrintLine(user.ToString());
            }

            MyConsole.PrintLine("\nBye");
        }
    }
}
