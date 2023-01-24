using System;

class TaxCalculator
{
    public void Tax(string[] args)
    {
        // Get annual salary from user
        Console.Write("\nEnter annual salary: ");
        double annualSalary = double.Parse(Console.ReadLine());

        // Set tax rates
        double basicRate = 0.2;
        double higherRate = 0.4;
        double additionalRate = 0.45;
        double basicThreshold = 50270;
        double higherThreshold = 150000;

        // Calculate tax
        double tax = 0;
        if (annualSalary <= basicThreshold)
        {
            tax = annualSalary * basicRate;
        }
        else if (annualSalary > basicThreshold && annualSalary <= higherThreshold)
        {
            tax = basicThreshold * basicRate + (annualSalary - basicThreshold) * higherRate;
        }
        else if (annualSalary > higherThreshold)
        {
            tax = basicThreshold * basicRate + (higherThreshold - basicThreshold) * higherRate + (annualSalary - higherThreshold) * additionalRate;
        }

        // Print tax to the console
        Console.WriteLine("\nYou will pay: £" + tax + " tax this year. \n");
        Console.WriteLine("\nYou will pay: £" + (tax / 12) + " tax per month. \n");
    }
}