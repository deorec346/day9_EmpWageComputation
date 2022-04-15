using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    internal class MonthlyWage
    {
        //Calculation of Monthly Wage
        public void MonthlyEmpWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int Emp_Rate_Per_Hour = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage );
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
