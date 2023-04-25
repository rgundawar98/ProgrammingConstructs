using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.IfElseIfStatements
{
    public class FindLargeNumber
    {
        public void Check_Larger_Number()
        {
            Console.WriteLine("Enter the First number");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int value3 = Convert.ToInt32(Console.ReadLine());
            if(value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
                Console.WriteLine("Value {0} is greater than others",value1);
            else if(value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
                Console.WriteLine("Value {0} is greater than others",value2);
            else
                Console.WriteLine("Value {0} is greater than others",value3);
        }
    }
}
