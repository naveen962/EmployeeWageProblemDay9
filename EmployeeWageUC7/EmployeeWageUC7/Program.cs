using System;

namespace EmployeeWageUC7
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageUC7.UseCase7 uc = new UseCase7();
            uc.ComputeEmpWage("BridgeLabz", 20, 10, 50);
            uc.ComputeEmpWage("JIO", 10, 20, 100);
        }
    }
}
