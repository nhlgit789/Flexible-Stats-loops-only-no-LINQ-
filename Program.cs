using System;

class Program
{
    static void Main()
    {
        int count = 0;
        long sum = 0; // long in case of large totals
        int min = 0, max = 0;
        bool firstNumber = true;

        while (true)
        {
            Console.Write("Enter a whole number (blank to finish): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break; // user pressed Enter on blank line
            }

            if (int.TryParse(input, out int value))
            {
                count++;
                sum += value;

                if (firstNumber)
                {
                    min = max = value;
                    firstNumber = false;
                }
                else
                {
                    if (value < min) min = value;
                    if (value > max) max = value;
                }
            }
            else
            {
                Console.WriteLine("Error: please enter a valid whole number.");
            }
        }

        if (count > 0)
        {
            double average = sum / (double)count;
            Console.WriteLine($"\nCount: {count}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {average:F2}");
        }
        else
        {
            Console.WriteLine("No valid numbers were entered.");
        }
    }
}
