using System;

class Calculator
{
    static void Main (String[] args)
    {
        Console.WriteLine("Simple MATH CALCULATOR!!");

        Console.WriteLine("Choose an operation: + - * /");
        string operation = Console.ReadLine();

        Console.WriteLine("Enter your first number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Connot divide by zero, the value is undefined");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation");
        }
            
        
        Console.WriteLine("Result is = " + result);
    }
}

