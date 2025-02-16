using System.Diagnostics;

namespace BMDBFileIO
{
    internal class Movie
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        public Movie() { }

        public Movie(int Id, string title, int Year, string Rating, string Director)
        {
            this.Id = Id;
            this.Title = title;
            this.Year = Year;
            this.Rating = Rating;
            this.Director = Director;
        }


        public override string ToString()
        {
            return $"Movie: ({Id}): {Title}, {Year}, {Rating}, {Director}";
        }
    }
}
