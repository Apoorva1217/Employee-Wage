using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Compute Employee Wage for Multiple Companies
        /// </summary>
        /// <param name="args"></param>

        //Constants
        const int PART_TIME = 1;
        const int FULL_TIME = 2;

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
	        totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Employee Hours:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage for company:" +company + "is:" +totalEmpWage);
            return totalEmpWage;
        }
        static void Main(String[] args)
        {
            ComputeEmpWage("Big Bazaar",20,26,180);
	    ComputeEmpWage("DMart",23,24,160);
        }
    }
}
