using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class ComputeGrade
    {
        public string GetGrade(int score)
        {
            if(score >= 70 && score < 100)
            {
                return "A";
            }
            else if (score >= 60 && score < 69)
            {
                return "B";
            }
            else if (score >= 50 && score < 59)
            {
                return "C";
            }
            else if (score >= 45 && score < 49)
            {
                return "D";
            }
            else if (score >= 40 && score < 44)
            {
                return "E";
            }
            else if (score >= 0 && score < 39)
            {
                return "F";
            }
            else
            {
                return "Invalid Entry!";
            }
        }

    }
}
