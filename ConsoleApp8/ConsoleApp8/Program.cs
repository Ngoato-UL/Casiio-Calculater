namespace ConsoleApp8
{
    internal class Calculator
    {
        // Constructor
        public Calculator()
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

        

       
        }

        
        

        
        }
    

