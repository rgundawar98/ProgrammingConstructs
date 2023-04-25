using ProgrammingConstructs.If_Else_Statement;
using System;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Programming Constructs");
            Console.WriteLine("Choose the option");
            Console.WriteLine("1.Number is equal or not\n2.Check Even or Odd\n3.Age Check for vote");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CheckNumbers numb = new CheckNumbers();
                    numb.Check_Numbers_Are_Equal_Or_Not();
                    break;
                case 2:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.Check_Number_Is_Even_Or_Not();
                    break;
                case 3:
                    AgeCheck age = new AgeCheck();
                    age.Check_Age_For_Election();
                    break;       
            }
        }
    }
}
