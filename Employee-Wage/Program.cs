using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Calculating Wages for a month
        /// </summary>
        /// <param name="args"></param>
		
	//Constants
	public const int PART_TIME=1;
	public const int FULL_TIME=2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
		
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Daily Employee Wage is:" + empWage);
            }
            Console.WriteLine("Total Employee Wage:" + totalEmpWage);
        }
    }
}
