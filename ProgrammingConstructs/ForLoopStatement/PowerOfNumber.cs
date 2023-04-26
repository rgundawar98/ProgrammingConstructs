using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.ForLoopStatement
{
    public class PowerOfNumber
    {
        public void Check_Power_Of_Number()
        {
            Console.WriteLine("Enter the number to make Power");
            int number = Convert.ToInt32(Console.ReadLine());
            double power = 1;
            for(int num=1; num <= number; num++)
            {
                power = power * 2;
                Console.WriteLine("2^{0}={1}",num,power);
            }
        }
    }
}
