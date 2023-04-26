using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.ForLoopStatement
{
    public class Factorial
    {
        public void Check_Factorial()
        {
            Console.WriteLine("Enter the number to make factorial of");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int num=1; num<=number; num++)
            {
                fact = fact * num;
                Console.WriteLine("Factorial will be:"+fact);
            }
        }
    }
}
