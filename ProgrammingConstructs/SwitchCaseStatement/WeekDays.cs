﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs.SwitchCaseStatement
{
    public class WeekDays
    {
        public void Day_Check()
        {
            Console.WriteLine("Enter the number form Weekdays");
            int WeekDay = Convert.ToInt32(Console.ReadLine());
            switch (WeekDay)
            {
                case 1:
                    Console.WriteLine("It's Sunday");
                    break;
                case 2:
                    Console.WriteLine("It's Monday");
                    break;
                case 3:
                    Console.WriteLine("It's Tuesday");
                    break;
                case 4:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 5:
                    Console.WriteLine("It's Thursday");
                    break;
                case 6:
                    Console.WriteLine("It's Friday");
                    break;
                case 7:
                    Console.WriteLine("It's Saturday");
                    break;
            }
        }
    }
}
