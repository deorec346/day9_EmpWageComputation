using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    internal class SwitchUser
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int Emp_Rate_Per_Hour = 20;
        // Calculation of Employee Wage Using Switch Case
        public void SwitchCase()
        {
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            switch (EmpCheck)
            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    Console.WriteLine("Employee is FullTime");
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    Console.WriteLine("Employee is PartTime");
                    break;

                default:
                    EmpHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage = " + EmpWage);
            Console.ReadLine();
        }

    }
}

