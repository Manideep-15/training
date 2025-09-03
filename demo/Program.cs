using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");

        Console.WriteLine("Please enter a number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Great! Now enter another number:");
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine($"The sum of {a} and {b} is {sum}");

        if (a > b)
        {
            Console.WriteLine($"{a} is bigger than {b}.");
        }
        else if (b > a)
        {
            Console.WriteLine($"{b} is bigger than {a}.");
        }
        else
        {
            Console.WriteLine($"Both numbers are equal, {a} and {b}.");
        }

        Console.WriteLine("Now, enter a number between 1 and 7 to find out the corresponding day of the week.");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Today is Monday.");
                break;
            case 2:
                Console.WriteLine("Today is Tuesday.");
                break;
            case 3:
                Console.WriteLine("Today is Wednesday.");
                break;
            case 4:
                Console.WriteLine("Today is Thursday.");
                break;
            case 5:
                Console.WriteLine("Today is Friday.");
                break;
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine(" That’s not a valid day number. Please enter a value between 1 and 7.");
                break;
        }

        Console.WriteLine("Let's count from 1 to 5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Program completed");
    }
}
