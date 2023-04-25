using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.If_Else_Statement
{
    public class CheckNumbers
    {
        public void Check_Numbers_Are_Equal_Or_Not()
        {
            Console.WriteLine("Enter the first number");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            int value2 = Convert.ToInt32(Console.ReadLine());
            if (value1 == value2)
                Console.WriteLine("Both numbers are equal to each other");
            else
                Console.WriteLine("Both numbers are not equal");
        }
    }
}
