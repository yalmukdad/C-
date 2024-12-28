using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Simple Calculator!");

            while (true)
            {
                // Get user input (with null handling)
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine() ?? ""); 

                Console.Write("Enter the operator (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine() ?? ""); 

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine() ?? ""); 

                // Perform calculation
                double result = Calculate(num1, op, num2);

                // Display result
                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

                // Ask if the user wants to continue (with null handling)
                Console.Write("Do you want to perform another calculation? (y/n): ");
                if (Console.ReadLine()?.ToLower() != "y") 
                {
                    break; 
                }
            }
        }

        static double Calculate(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return 0; 
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return 0; 
            }
        }
    }
}