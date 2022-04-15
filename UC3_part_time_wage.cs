using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    internal class PartTimeWage
    {
        //Calculation of Part Time Wage
        public void PartTimeEmpWage()
        {   int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int Emp_Rate_Per_Hour = 20; 
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            if (EmpCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee is FullTime");
            }
            else if (EmpCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
                Console.WriteLine("Employee is PartTime");
            }
            else
            {
                EmpHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employeewage = " + EmpWage);
            Console.ReadLine();

        }
    }
}
