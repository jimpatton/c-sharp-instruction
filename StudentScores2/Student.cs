namespace StudentScores2
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        
        public Student(string firstName, string lastName, int score)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Score = score;
        }
        public override string ToString()
        {
            return ($"\n{LastName}, {FirstName}: {Score}");
        }

    }
}
