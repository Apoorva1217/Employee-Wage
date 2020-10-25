using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Check Employee Presence
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Constant
            const int FULL_TIME = 1;
            Random random = new Random();
            //Variable
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
        }
    }
}