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
}
    }
}

