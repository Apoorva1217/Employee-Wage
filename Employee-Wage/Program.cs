using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Calculate Daily Employee Wage
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Constants
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
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