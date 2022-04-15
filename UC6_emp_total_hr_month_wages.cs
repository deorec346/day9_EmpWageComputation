using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    internal class TotalHrMonthCondition
    {
        
        //Condition
        public void TotalHrMonthConditions()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int Emp_Rate_Per_Hour = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 100;
            int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0, Day = 1, TotalEmpWage = 0, empWage = 0, workingHrs = 0;
            while (Day <= NUM_OF_WORKING_DAYS && TotalEmpHrs <= MAX_HRS_IN_MONTH)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;

                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }
                empWage = Emp_Rate_Per_Hour * EmpCheck;    
                Console.WriteLine("Dily Wage for day{0} is:{1}",Day,empWage);
                TotalEmpWage += empWage;
                workingHrs += empWage;
                Day++;
            }
            Console.WriteLine("TotalEmpWage for {0} and Working hrsdays is{1}", Day, workingHrs, TotalEmpWage);
            Console.ReadLine();

        }
    }
}
    
