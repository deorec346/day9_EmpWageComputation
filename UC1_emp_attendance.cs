using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    public class EmployeeWage
    {
        const int IS_FULL_TIME = 1;
       
        public void EmployeeAttendance()
        {

            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            // code block
            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }

    }
}
