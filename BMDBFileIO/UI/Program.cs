using System.Collections.Concurrent;
using System.Net.Http.Headers;
using BMDBFileIO.Database;
using BMDBFileIO.Model;
using ConsoleLibrary;

namespace BMDBFileIO.UI
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
            MyConsole.PrintLine("BMDB File IO!\n");

            movies = MovieDB.GetMovies();

            int command = 5;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        GetMovieById();
                        break;
                    case 3:
                        AddMovie();
                        break;
                    case 4:
                        DeleteMovieByID();
                        break;
                    case 0:
                        break;



                }
            }












            MyConsole.PrintLine("\nBye");
        }

        private static void DeleteMovieByID()
        {
            MyConsole.PrintLine("\nDelete Movie by ID");
            MyConsole.PrintLine("=====================");
            int id = MyConsole.PromptInt("Enter Id for movie to delete: ");
            //loop through movies
            //find movie whose id matches id to delete
            //remove movie
            Movie found = null;
            foreach (Movie movie in movies)
            {
                if (movie.Id == id)
                {
                    found = movie;
                    break;
                }
            }
            if (found != null)
            {
                movies.Remove(found);
                MovieDB.SaveMovie(movies);
                MyConsole.PrintLine("\nMovie removed.");
            }
            else
            {
                MyConsole.PrintLine("\nMovie not found");
            }
        }

        private static void AddMovie()
        {
            MyConsole.PrintLine("\nAdd Movie");
            MyConsole.PrintLine("=====================");
            int Id = MyConsole.PromptInt("Id: ");
            string Title = MyConsole.PromptString("Title: ");
            int Year = MyConsole.PromptInt("Year: ");
            string Rating = MyConsole.PromptString("Rating: ");
            string Director = MyConsole.PromptString("Director: ");
            Movie m = new Movie(Id, Title, Year, Rating, Director);
            movies.Add(m);
            MovieDB.SaveMovie(movies);
            MyConsole.PrintLine("\nMovie added.\n");
        }

        private static void GetMovieById()
        {
            MyConsole.PrintLine("\nGet Movie by ID");
            MyConsole.PrintLine("=====================");
            int id = MyConsole.PromptInt("Enter Id for movie: ");
            Movie found = null;
            foreach (Movie m in movies)
            {
                if (m.Id == id)
                {
                    found = m;
                    break;
                }

            }
            if (found != null)
            {
                // found movie id
                MyConsole.PrintLine(found.ToString());
            }
            else
            {
                MyConsole.PrintLine("\nMovie not found");
            }



        }

        private static void ListAll()
        {
            MyConsole.PrintLine("\nList All");
            MyConsole.PrintLine("=====================");
            foreach (Movie m in movies)
            {
                MyConsole.PrintLine(m.ToString());
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU");
            MyConsole.PrintLine("1) List All");
            MyConsole.PrintLine("2) Get Movie by ID");
            MyConsole.PrintLine("3) Add Movie");
            MyConsole.PrintLine("4) Delete Movie by ID");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
