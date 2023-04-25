using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.If_Else_Statement
{
    public class EvenOdd
    {
        public void Check_Number_Is_Even_Or_Not()
        {
            Console.WriteLine("Enter the number");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value%2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
