using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_GradeConverter
{
    internal class Grade
    {
        public int grade { get; set; }
        public string letterGrade { get; private set; }

        public Grade() { }

        public Grade(int grade) {
            this.grade = grade;
            this.letterGrade = letterGrade;
        }

        public static string getLetterGrade(int grade)
        {
            string letterGrade;
            if (grade >= 88)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 69)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade;
            
        }


    }
}
