using System;

namespace ConsoleApp8
{
    internal class Calculater
    {
        public Calculater() { }

        // Helper: read a double safely from console
        private double ReadDouble(string prompt, bool disallowZero = false, bool positiveOnly = false)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                {
                    if (disallowZero && value == 0)
                    {
                        Console.WriteLine("Value cannot be zero. Try again.");
                        continue;
                    }
                    if (positiveOnly && value <= 0)
                    {
                        Console.WriteLine("Value must be positive. Try again.");
                        continue;
                    }
                    return value;
                }
                Console.WriteLine("Invalid number. Please enter a valid numeric value.");
            }
        }

        // Helper: read a non-negative integer for factorial
        private int ReadNonNegativeInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= 0)
                    return value;
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        public void AddNumbers()
        {
            double num1 = ReadDouble("Enter the first number: ");
            double num2 = ReadDouble("Enter the second number: ");
            double result = num1 + num2;
            Console.WriteLine($"Result: {result}");
        }

        public void SubtractNumbers()
        {
            double num1 = ReadDouble("Enter the first number: ");
            double num2 = ReadDouble("Enter the second number: ");
            double result = num1 - num2;
            Console.WriteLine($"Result: {result}");
        }

        public void MultiplyNumbers()
        {
            double num1 = ReadDouble("Enter first number: ");
            double num2 = ReadDouble("Enter second number: ");
            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} × {num2} = {result}");
        }

        public void DivideNumbers()
        {
            double num1 = ReadDouble("Enter numerator: ");
            double num2 = ReadDouble("Enter denominator: ", disallowZero: true);
            double result = num1 / num2;
            Console.WriteLine($"Result: {num1} ÷ {num2} = {result}");
        }

        public void SquareRoot()
        {
            double num = ReadDouble("Enter a number: ");
            if (num < 0)
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                return;
            }
            double result = Math.Sqrt(num);
            Console.WriteLine($"Result: √{num} = {result}");
        }

        public void Power()
        {
            double baseNum = ReadDouble("Enter base number: ");
            double exponent = ReadDouble("Enter exponent: ");
            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine($"Result: {baseNum}^{exponent} = {result}");
        }

        // Natural logarithm (ln)
        public void NaturalLog()
        {
            double num = ReadDouble("Enter a number: ", positiveOnly: true);
            double result = Math.Log(num);
            Console.WriteLine($"Result: ln({num}) = {result}");
        }

        // Log base 10
        public void Log10()
        {
            double num = ReadDouble("Enter a number: ", positiveOnly: true);
            double result = Math.Log10(num);
            Console.WriteLine($"Result: log10({num}) = {result}");
        }

        // Custom log with specified base
        public void CustomLog()
        {
            double num = ReadDouble("Enter the number: ", positiveOnly: true);
            double baseNum = ReadDouble("Enter the base (must be > 0 and ≠ 1): ");
            if (baseNum <= 0 || baseNum == 1)
            {
                Console.WriteLine("Error: Base must be positive and not equal to 1.");
                return;
            }
            double result = Math.Log(num, baseNum);
            Console.WriteLine($"Result: log base {baseNum} of {num} = {result}");
        }

        // Dispatcher used by menu to choose a log variant
        public void Logarithm()
        {
            Console.WriteLine("Log options: 1) Natural log (ln)  2) log10  3) Custom base");
            Console.Write("Choose option: ");
            string? opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    NaturalLog();
                    break;
                case "2":
                    Log10();
                    break;
                case "3":
                    CustomLog();
                    break;
                default:
                    Console.WriteLine("Invalid log option.");
                    break;
            }
        }

        public void Sine()
        {
            double degrees = ReadDouble("Enter angle in degrees: ");
            double radians = degrees * Math.PI / 180.0;
            Console.WriteLine($"sin({degrees}°) = {Math.Sin(radians)}");
        }

        public void Cosine()
        {
            double degrees = ReadDouble("Enter angle in degrees: ");
            double radians = degrees * Math.PI / 180.0;
            Console.WriteLine($"cos({degrees}°) = {Math.Cos(radians)}");
        }

        public void Tangent()
        {
            double degrees = ReadDouble("Enter angle in degrees: ");
            double radians = degrees * Math.PI / 180.0;
            Console.WriteLine($"tan({degrees}°) = {Math.Tan(radians)}");
        }

        public void Factorial()
        {
            int n = ReadNonNegativeInt("Enter a non-negative integer: ");
            try
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                    result = checked(result * i); // detect overflow
                Console.WriteLine($"{n}! = {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result is too large to fit in a 64-bit integer.");
            }
        }

        public void Percentage()
        {
            double num = ReadDouble("Enter the number: ");
            double percentage = ReadDouble("Enter the percentage: ");
            double result = (num * percentage) / 100.0;
            Console.WriteLine($"Result: {percentage}% of {num} = {result}");
        }

        public void AbsoluteValue()
        {
            double num = ReadDouble("Enter a number: ");
            double result = Math.Abs(num);
            Console.WriteLine($"Result: |{num}| = {result}");
        }
    }
}





