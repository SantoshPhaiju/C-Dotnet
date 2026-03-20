using OOP.Calculator;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOPClass obj = new OOPClass();
            // obj.Info();
            // System.Console.WriteLine(obj.GetName());
            MyCalculator calculator = new MyCalculator();
            MyCalculator calculator2 = new MyCalculator("Custom welcome message");
            Console.WriteLine("========== WELCOME TO MY CALCULATOR CONSOLE APP ===========");

            while (true)
            {   
                System.Console.WriteLine("Enter 1 for Add\t Enter 2 for Subtract\t Enter 3 for Multiply\t Enter 4 for Divide\t Enter 5 for exit!");

                int key;
                if(!int.TryParse(Console.ReadLine(), out key))
                {
                    System.Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (key)
                {
                    case 1:
                        System.Console.WriteLine("Enter two numbers:");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Result: " + calculator.Add(a, b));
                        break;
                    case 2:
                        System.Console.WriteLine("Enter two numbers:");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Result: " + calculator.Sub(num1, num2));
                        break;
                    case 3:
                        System.Console.WriteLine("Enter two numbers:");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Result: " + calculator.Mul(x, y));
                        break;
                    case 4:
                        System.Console.WriteLine("Enter two numbers:");
                        int dividend = int.Parse(Console.ReadLine());
                        int divisor = int.Parse(Console.ReadLine());
                        if (divisor == 0)
                        {
                            System.Console.WriteLine("Cannot divide by zero. Please try again.");
                        }
                        else
                        {
                            System.Console.WriteLine("Result: " + calculator.Divide(dividend, divisor));
                        }   
                        break;
                    case 5: 
                        System.Console.WriteLine("Thank you for visiting my calculator");
                        return;
                    default: 
                        System.Console.WriteLine("Hello miss");
                        break;
                }

            }
        }
    }
}