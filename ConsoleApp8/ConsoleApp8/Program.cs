CO
using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculater calc = new Calculater();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== CALCULATOR MENU ====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Square Root");
                Console.WriteLine("6. Power");
                Console.WriteLine("7. Logarithm");
                Console.WriteLine("8. Sine");
                Console.WriteLine("9. Cosine");
                Console.WriteLine("10.Tangent");
                Console.WriteLine("11.Factorial");
                Console.WriteLine("12.Absolute Value");
                Console.WriteLine("13.Percentage");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        calc.AddNumbers();
                        break;

                    case "2":
                        calc.SubtractNumbers();
                        break;

                    case "3":
                        calc.MultiplyNumbers();
                        break;

                    case "4":
                        calc.DivideNumbers();
                        break;

                    case "5":
                        calc.SquareRoot();
                        break;

                    case "6":
                        calc.Power();
                        break;

                    case "7":
                        calc.Logarithm();
                        break;

                    case "8":
                        calc.Sine();
                        break;

                    case "9":
                        calc.Cosine();
                        break;

                    case "10":
                        calc.Tangent();
                        break;

                    case "11":
                        calc.Factorial();
                        break;

                    case "12":
                        calc.AbsoluteValue();
                        break;

                    case "13":
                        calc.Percentage();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
                Console.WriteLine("Thank you for using the calculator. Goodbye!");
                Console.ReadLine();
            }
        }
    }
}




