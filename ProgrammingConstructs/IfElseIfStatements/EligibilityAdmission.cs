using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.IfElseIfStatements
{
    public class EligibilityAdmission
    {
        public void Check_Eligible_Candidate()
        {
            Console.WriteLine("Enter Maths score");
            int Math_Score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics score");
            int Physics_Score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry score");
            int Chemistry_Score = Convert.ToInt32(Console.ReadLine());
            int Total_Marks = Math_Score + Physics_Score + Chemistry_Score;
            Console.WriteLine(Total_Marks);
            if(Total_Marks >= 140)
                Console.WriteLine("The candidate is eligible for admmision");
            else
                Console.WriteLine("The data inadequate");
        }
    }
}
