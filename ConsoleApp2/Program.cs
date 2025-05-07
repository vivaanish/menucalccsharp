using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 for Sum");
            Console.WriteLine("Enter 2 for Multiply");
            Console.WriteLine("Enter 3 for Subtract");
            Console.WriteLine("Enter 4 to Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 4)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            Console.Write("Enter first number: ");
            double fv = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter second number: ");
            double sv = double.Parse(Console.ReadLine() ?? "0");

            double result = 0;

            if (choice == 1)
            {
                Console.Write("Do you want to enter third number? (y/n): ");
                string ch = Console.ReadLine() ?? "n";
                if (ch == "y")
                {
                    Console.Write("Enter third number: ");
                    double tv = double.Parse(Console.ReadLine() ?? "0");
                    result = sumThree(fv, sv, tv);
                }
                else
                {
                    result = sum(fv, sv);
                }
                Console.WriteLine($"Sum is {result}");
            }
            else if (choice == 2)
            {
                result = multiply(fv, sv);
                Console.WriteLine($"Multiply is {result}");
            }
            else if (choice == 3)
            {
                result = subtract(fv, sv);
                Console.WriteLine($"Subtract is {result}");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.WriteLine(); // Add a blank line for better readability
        }
    }

    static double sum(double fv, double sv)
    {
        double result = fv + sv;
        return result;
    }

    static double sumThree(double fv, double sv, double tv)
    {
        double result = fv + sv + tv;
        return result;
    }

    static double multiply(double fv, double sv)
    {
        double result = fv * sv;
        return result;
    }

    static double subtract(double fv, double sv)
    {
        double result = fv - sv;
        return result;
    }
}