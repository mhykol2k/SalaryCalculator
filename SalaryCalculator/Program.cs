using System;
using System.Runtime.InteropServices;

class HourlyWageCalculator
{
    static void Main(string[] args)
    {
        void AddSecondWage(double secondWage)
        {
            // Create an instance of the TaxCalculator class
            TaxCalculator taxCalculator = new TaxCalculator();
            // Call the Tax method
            taxCalculator.Tax(args);

            StudentLoanCalculator studentLoanCalculator = new StudentLoanCalculator();
            studentLoanCalculator.StudentLoan(args);

            Console.WriteLine("Please press enter to move on...");
            Console.ReadLine();

            double totalSecondWage = 0;
            for (double increment = 0; increment < 60; increment++)
            {
                totalSecondWage += secondWage;
                secondWage = Math.Round(secondWage, 4);
                Console.WriteLine("You have earnt: £" + Math.Round(totalSecondWage, 2) + "p");
                System.Threading.Thread.Sleep(1000);
            }
        }

        // Get annual salary from user
        Console.Write("Enter annual salary: ");
        double annualSalary = double.Parse(Console.ReadLine());

        // Get number of work hours per week from user
        Console.Write("Enter number of work hours per week: ");
        double hoursPerWeek = double.Parse(Console.ReadLine());

        // Get number of work hours per week from user
        Console.Write("Enter number of work days per week: ");
        double workDays = double.Parse(Console.ReadLine());

        // Calculate hourly wage
        double hourlyWage = (annualSalary / 52) / hoursPerWeek;
        // Calculate wage per minute
        double minuteWage = hourlyWage / 60;
        // Calculate wage per second
        double secondWage = minuteWage / 60;

        // Print hourly wage to the console

        Console.WriteLine("3-Monthly wage: £" + (hourlyWage * hoursPerWeek / workDays * workDays * 4) * 3 + "\n");
        Console.WriteLine("Monthly wage: £" + (hourlyWage * hoursPerWeek / workDays * workDays * 4) + "\n");
        Console.WriteLine("Weekly wage: £" + (hourlyWage * hoursPerWeek / workDays * workDays) + "\n");
        Console.WriteLine("Daily  wage: £" + (hourlyWage * hoursPerWeek / workDays) + "\n");
        Console.WriteLine("Hourly wage: £" + hourlyWage + "\n");
        Console.WriteLine("Minute wage: £" + minuteWage + "\n");
        Console.WriteLine("Second wage: £" + secondWage + "\n");

        AddSecondWage(secondWage);



        Console.WriteLine("Please press enter to close...");
        Console.ReadLine();

        //test
    }

}