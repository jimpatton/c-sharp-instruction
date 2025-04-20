using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Xml.Serialization;

namespace chap12Demos
{
    internal class Program
    {
        static List<Movie> Movies = new List<Movie>();


        static void Main(string[] args)
        {
            MyConsole.PrintLine("chapt 12 Classes Demo!");


            Movie newMovie = new Movie();
            newMovie.Id = 1;
            newMovie.Title = "Jurassic World Rebirth";
            newMovie.Year = 2025;
            newMovie.Rating = "PG-13";
            newMovie.Director = "Gareth Edwards";
            Movies.Add(newMovie);

            //PrintLine($"newMovie title = {newMovie.Title}");
            //PrintLine(newMovie.ToString());
            string choice = "y";
            while (choice == "y")
            {
                //capture input for properties of a movie
                int id = MyConsole.PromptInt("Movie ID: ");
                string title = MyConsole.PromptString("Movie Title: ");
                int year = MyConsole.PromptInt("Year: ");
                string ageRating = MyConsole.PromptString("Age rating: ");
                string director = MyConsole.PromptString("Director: ");
                //store this movie and capture a new one
                newMovie = new Movie(id, title, year, ageRating, director);
                Movies.Add(newMovie);
                choice = MyConsole.PromptString("Add another movie? (y/n)");
            }
            //PrintLine (newMovie.ToString());
            //display all movies
            MyConsole.PrintLine("===========MOVIES==========");
            foreach (Movie movie in Movies)
            {
                MyConsole.PrintLine(movie.ToString());
            }



            MyConsole.PrintLine("Bye");
        }

       

    }
}
