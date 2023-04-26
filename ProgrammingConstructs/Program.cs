using ProgrammingConstructs.ForLoopStatement;
using ProgrammingConstructs.If_Else_Statement;
using ProgrammingConstructs.IfElseIfStatements;
using ProgrammingConstructs.SwitchCaseStatement;
using System;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Programming Constructs");
            Console.WriteLine("Choose the option");
            Console.WriteLine("1.Number is equal or not\n2.Check Even or Odd\n3.Age Check for vote\n4.Largest Number" +
                "\n5.Admission Eligibility\n6.WeekDays\n7.Arithmetic Operation\n8.Power Of Number\n9.Factorial" +
                "\n10.SquareOfNumber");
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
                case 4:
                    FindLargeNumber number = new FindLargeNumber();
                    number.Check_Larger_Number();
                    break;
                case 5:
                    EligibilityAdmission admission = new EligibilityAdmission();
                    admission.Check_Eligible_Candidate();
                    break;
                case 6:
                    WeekDays week = new WeekDays();
                    week.Day_Check();
                    break;
                case 7:
                    ArithmeticOperation operation = new ArithmeticOperation();
                    operation.Check_Arithmetic_Operation();
                    break;
                case 8:
                    PowerOfNumber power = new PowerOfNumber();
                    power.Check_Power_Of_Number();
                    break;
                case 9:
                    Factorial factorial = new Factorial();
                    factorial.Check_Factorial();
                    break;
                case 10:
                    SquareOfNumber Number = new SquareOfNumber();
                    Number.Check_Square_Of_Number();
                    break;
            }
        }
    }
}
