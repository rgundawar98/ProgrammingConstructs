using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.If_Else_Statement
{
    public class AgeCheck
    {
        public void Check_Age_For_Election()
        {
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("Age:{0} is eligible for voting",age);
            else
                Console.WriteLine("Age:{0} is not eligible for voting",age);
        }
    }
}
