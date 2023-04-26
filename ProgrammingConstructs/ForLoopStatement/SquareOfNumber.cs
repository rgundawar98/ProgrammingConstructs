using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.ForLoopStatement
{
    public class SquareOfNumber
    {
        public void Check_Square_Of_Number()
        {
            Console.WriteLine("Enter the number");
            int value = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int num=1;num<=value;num++)
            {
                Console.Write("{0} ", num * num);
                sum += num * num; 
            }
            Console.WriteLine("\nThe sum of squares of a number is:{0} Sum is ={1}",value,sum);
        }
    }
}
