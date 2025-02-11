namespace LetterGrade
{
    public class Grade
    {
        public int Number { get; set; }

        public Grade()
        {
            this.Number = 0;
        }

        public Grade(int Number)
        {
            this.Number = Number;
        }
        public string GetLetter()
        {
            string returnStr = "";
            //if Number >= 88 return "A"
            if (Number >= 88)
            {
                returnStr = "A";
            }
            //else if Number >= 80 return "B"
            else if (Number >= 80)
            {
                returnStr = "B";
            }
            //else if Number >= 67 return "C"
            else if (Number >= 67)
            {
                returnStr = "C";
            }
            //else if Number >=60 return "D"
            else if (Number >= 60)
            {
                 returnStr = "D";
            }
            //else return "F"
            else
            {
                returnStr = "F";
            }
            return returnStr;


        }


















    }
}
