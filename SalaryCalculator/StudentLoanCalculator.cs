using System;

class StudentLoanCalculator
{
    public void StudentLoan(string[] args)
    {
        // Get annual salary from user
        Console.Write("Enter annual salary: ");
        double annualSalary = double.Parse(Console.ReadLine());

        // Call the Repayment method
        Repayment(annualSalary);

        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }

    public static void Repayment(double annualSalary)
    {
        // Set repayment threshold and rate
        double repaymentThreshold = 27295;
        double repaymentRate = 0.09;

        // Calculate repayment
        double repayment = 0;
        if (annualSalary > repaymentThreshold)
        {
            repayment = (annualSalary - repaymentThreshold) * repaymentRate;
        }

        // Print repayment to the console
        Console.WriteLine("Student loan repayment: £" + repayment);
    }
}
