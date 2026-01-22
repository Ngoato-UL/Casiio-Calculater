using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Calculater
    {
            public Calculater()
    {
    }

    public void AddNumbers()
    {
        Console.WriteLine("enter the first number");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($" Result: {result}");
    }

    public void SubtractNumbers()
    {
        Console.WriteLine("enter the first number ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 - num2;
        Console.WriteLine("the sum is :" + sum);
    }

    public void MultiplyNumbers()
    {
        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"Result: {num1} × {num2} = {result}");
    }

    // there are 2 DivideNumbers methods here, removed the duplicate
    public void DivideNumbers()
    {
        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        // check for division by zero
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return;
        }

        double result = num1 / num2;
        Console.WriteLine($"Result: {num1} ÷ {num2} = {result}");
    }
         public void SquareRoot()
        {
            Console.WriteLine("Enter a number:");
            double num = double.Parse(Console.ReadLine());

            // check for negative input
            if (num < 0)
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
            }
            else
            {
                double result = Math.Sqrt(num);
                Console.WriteLine($"Result: √{num} = {result}");
            }
        }

        public void Power()
        {
            Console.WriteLine("Enter base number:");
            double baseNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter exponent:");
            double exponent = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine($"Result: {baseNum}^{exponent} = {result}");
        }

        // ln - natural log
        public void naturalLog()
        {
            Console.WriteLine("Enter a number:");
            double num1 = double.Parse(Console.ReadLine());

            // check if input is positive
            if (num1 <= 0)
            {
                Console.WriteLine("Error: Natural log is undefined for non-positive numbers.");
            }
            else
            {
                double result = Math.Log(num1);
                Console.WriteLine($"Result: ln({num1}) = {result}");
            }
        }
        // add method 
         public void SquareRoot()
 {
     Console.WriteLine("Enter a number:");
     double num = double.Parse(Console.ReadLine());

     // check for negative input
     if (num < 0)
     {
         Console.WriteLine("Error: Cannot calculate square root of a negative number.");
     }
     else
     {
         double result = Math.Sqrt(num);
         Console.WriteLine($"Result: √{num} = {result}");
     }
 }

 public void Power()
 {
     Console.WriteLine("Enter base number:");
     double baseNum = double.Parse(Console.ReadLine());

     Console.WriteLine("Enter exponent:");
     double exponent = double.Parse(Console.ReadLine());

     double result = Math.Pow(baseNum, exponent);
     Console.WriteLine($"Result: {baseNum}^{exponent} = {result}");
 }

 // ln - natural log
 public void naturalLog()
 {
     Console.WriteLine("Enter a number:");
     double num1 = double.Parse(Console.ReadLine());

     // check if input is positive
     if (num1 <= 0)
     {
         Console.WriteLine("Error: Natural log is undefined for non-positive numbers.");
     }
     else
     {
         double result = Math.Log(num1);
         Console.WriteLine($"Result: ln({num1}) = {result}");
     }
 }
          // log10 - base 10 log
        public void Log10()
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            // check if input is positive
            if (num1 <= 0)
            {
                Console.WriteLine("Error: Log base 10 is undefined for non-positive numbers.");
            }
            else
            {
                double result = Math.Log10(num1);
                Console.WriteLine($"Result: log10({num1}) = {result}");
            }
        }

        // custom log with user-defined base
        public void CustomLog()
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base number");
            double baseNum = double.Parse(Console.ReadLine());

            // check if input is valid
            if (num1 <= 0 || baseNum <= 1)
            {
                Console.WriteLine("Error: Logarithm is undefined for non-positive numbers and base must be greater than 1.");
            }
            else
            {
                double result = Math.Log(num1, baseNum);
                Console.WriteLine($"Result: log base {baseNum} of {num1} = {result}");
            }
        }

} // end of class
    } // end of namespace




