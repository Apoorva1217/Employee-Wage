using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Refactor the code to write a Class Method to compute Employee Wage
        /// </summary>
        /// <param name="args"></param>

        //Constants
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        public static int ComputeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingDays++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Employee Hours:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage:" + totalEmpWage);
            return totalEmpWage;
        }
        public static void Main(String[] args)
        {
            ComputeEmpWage();
        }
    }
}