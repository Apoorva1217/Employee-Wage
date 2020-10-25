using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Add Part Time Employee and Wage
        /// </summary>
        /// <param name="args"></param>
		
	//Constants
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
		
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else if(empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
        }
    }
}
