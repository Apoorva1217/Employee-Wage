using System;
namespace Employee
{
    class Program
    {
        /// <summary>
        /// Ability to save total wage for each company
        /// </summary>
        /// <param name="args"></param>
		static void Main(String[] args)
        {
            EmployeeBuilderObject big_bazaar = new EmployeeBuilderObject("Big Bazaar",20,26,180);
			EmployeeBuilderObject dmart = new EmployeeBuilderObject("Dmart",23,24,160); 
			big_bazaar.computeEmpWage();
			Console.WriteLine(big_bazaar.toString());
			dmart.computeEmpWage();
			Console.WriteLine(dmart.toString());
		}
	}
}

public class EmployeeBuilderObject
{
    //Constants
    public const int PART_TIME = 1;
    public const int FULL_TIME = 2;

    private string company;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    public EmployeeBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company=company;
	this.empRatePerHour=empRatePerHour;
	this.numOfWorkingDays=numOfWorkingDays;
	this.maxHoursPerMonth=maxHoursPerMonth;
    }
    public void computeEmpWage()
    {
	//Variables
	int empHrs=0;
	int totalEmpHrs=0;
	int totalWorkingDays=0;

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
        totalEmpWage = totalEmpHrs * this.empRatePerHour;
    }
    public string toString()
    {
	return "Total Employee Wage for Company:" + this.company + "is:" + this.totalEmpWage;
    }
}
