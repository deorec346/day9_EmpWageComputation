using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    public class DailyWage
    {
        //Calculation of Daily Wage
        public void DailyWages()
        {
            int IS_FULL_TIME = 0;
            int IS_PART_TIME = 1;
            int Emp_Rate_Per_Hour = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Therefore EmpWage is " + EmpWage);
            Console.ReadLine();
        }

    }

}
