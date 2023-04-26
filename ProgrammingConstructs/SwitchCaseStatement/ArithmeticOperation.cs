using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.SwitchCaseStatement
{
    public class ArithmeticOperation
    {
        public void Check_Arithmetic_Operation()
        {
            Console.WriteLine("Enter the first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose option from below to do arithmetic operation");
            Console.WriteLine("\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    int var1 = First + Second;
                    Console.WriteLine("Addition will be:{0}", var1);
                    break;
                case 2:
                    int var2 = First - Second;
                    Console.WriteLine("Substraction will be:{0}", var2);
                    break; 
                case 3:
                    int var3 = First * Second;
                    Console.WriteLine("Multiplication will be:{0}", var3);
                    break;
                case 4:
                    int var4 = First/Second;
                    Console.WriteLine("Division will be:{0}", var4);
                    break;
            }
        }
    }
}
