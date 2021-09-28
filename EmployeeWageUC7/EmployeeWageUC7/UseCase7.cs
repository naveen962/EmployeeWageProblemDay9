using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUC7
{
    class UseCase7
    {
        public void ComputeEmpWage(string Company ,int EMPWAGE_PER_HOUR, int Num_Working_of_days, int max_work_hrs_month)

        {
           
            //variables
            int EmpHours = 0;
            int Empwage = 0;
            int Totalwages = 0;
            int Totalworkhrs = 0;
            int totalworkingdays = 0;


            //computation
            while (Totalworkhrs <= max_work_hrs_month && totalworkingdays < Num_Working_of_days)
            {
                Random ran = new Random();
                int Empcheck = ran.Next(0, 3);
                switch (Empcheck)
                {
                    case 1:
                        Console.WriteLine("PART TIME");
                        EmpHours = 4;
                        break;

                    case 2:
                        Console.WriteLine("FULL Time");
                        EmpHours = 8;
                        break;
                    default:
                        Console.WriteLine("ABSENT");
                        EmpHours = 0;
                        break;

                }
                totalworkingdays++;
                Totalworkhrs += EmpHours;

                Empwage = Totalworkhrs * EMPWAGE_PER_HOUR;
                Console.WriteLine("TOTAL EMPLOYEE WAGE FOR COMPANY "+Company+"is :" + Empwage);
                Totalwages += Empwage;
               

            }
            Console.WriteLine("TOTAL WAGES OF COMPANY =" + Totalwages);
        }
    }
}
