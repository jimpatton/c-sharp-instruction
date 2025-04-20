namespace StudentScores
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public Student() { }
        public Student(string lastName, string firstName, int score)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Score = score;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}: {Score}";           
        }







    }
}
