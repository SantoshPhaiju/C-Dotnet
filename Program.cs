namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOPClass obj = new OOPClass();
            // obj.Info();
            // System.Console.WriteLine(obj.GetName());
            Console.WriteLine("========== WELCOME TO MY CALCULATOR CONSOLE APP ===========");

            while (true)
            {   
                System.Console.WriteLine("Enter 1 for Add\t Enter 2 for Subtract\t Enter 3 for Multiply\t Enter 4 for Divide\t Enter 5 for exit!");

                string input = Console.ReadLine();
                int key = int.Parse(input);

                switch (key)
                {
                    case 1:
                        System.Console.WriteLine("Hello world");
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