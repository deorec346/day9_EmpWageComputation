using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to RFP-131Batch");
            Console.WriteLine("1:EmployeeWageComputations\n2:DailyWage\n3:PartTimeWage\n4:SwitchUser\n5:MonthlyWage\n6:TotalyHrMonthCondition\n7:Refactor:");
            int option = Convert.ToInt32(Console.ReadLine());//"1"
            switch (option)
            {
                case 1:
                    EmployeeWage employeeWage = new EmployeeWage();
                    employeeWage.EmployeeAttendance();
                    Console.WriteLine();
                    break;

                case 2:
                    DailyWage dailyWage = new DailyWage();
                    dailyWage.DailyWages();
                    Console.WriteLine();
                    break;
                case 3:
                    PartTimeWage partTimeWage = new PartTimeWage();
                    partTimeWage.PartTimeEmpWage();
                    Console.WriteLine();
                    break;
                case 4:
                    SwitchUser switchUser = new SwitchUser();
                    switchUser.SwitchCase();
                    Console.WriteLine();
                    break;
                case 5:
                    MonthlyWage monthlyWage = new MonthlyWage();
                    monthlyWage.MonthlyEmpWage();
                    Console.WriteLine();
                    break;
                case 6:
                    TotalHrMonthCondition totalHrCondition = new TotalHrMonthCondition();
                    totalHrCondition.TotalHrMonthConditions();
                    Console.WriteLine();
                    break;
                case 7:
                    UC7_Refactor uC7_Refactor = new UC7_Refactor();
                    uC7_Refactor.Condition();
                    uC7_Refactor.Display();
                    Console.ReadLine();
                    Console.WriteLine();
                    break;


                default:
                    Console.WriteLine("Please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    }
}
