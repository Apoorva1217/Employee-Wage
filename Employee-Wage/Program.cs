using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Calculate Wages till a condition of totalworking hours or days is reached for a month
        /// </summary>
        /// <param name="args"></param>
		
	//Constants
	public const int PART_TIME=1;
	public const int FULL_TIME=2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
		
        static void Main(string[] args)
        {
            
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                Console.WriteLine("Day:" + totalWorkingDays+"Employee Hours:"+empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage:" + totalEmpWage);
        }
    }
}
