using System;

public class Program
{
    static void Main(string[] args)
    {
        PrintHeart();
        Console.WriteLine();
        PrintTree(5); 
        Console.WriteLine();
        PrintLadder(5); 
        Console.WriteLine();
        CalculateAverage(new int[] { 1, 10, 9, 5 });
        Console.WriteLine();
        int[] numbers = { 3, 7, 2, 9, 4 };
        Console.WriteLine("Maximum value: " + FindMax(numbers));
    }

    static void PrintHeart()
    {
        Console.WriteLine("    **   ** ");
        Console.WriteLine("  *    *    *");
        Console.WriteLine(" *            *");
        Console.WriteLine(" *            *");
        Console.WriteLine("  *          *");
        Console.WriteLine("    *      *");
        Console.WriteLine("      *  *");
        Console.WriteLine("        *");
    }

    static void PrintTree(int height)
    {
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(new string(' ', height - i - 1) + new string('*', i * 2 + 1));
        }

        Console.WriteLine(new string(' ', height - 1) + "|");
    }

    static void PrintLadder(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine("|   |");
            Console.WriteLine("|___|");
        }
    }
    
    static void CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty or null");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Average: " + (double)sum / numbers.Length);
    }
    
    static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty or null");
        }

        int max = numbers[0];
        foreach (int f in numbers)
        {
            if (f > max)
            {
                max = f;
            }
        }

        return max;
    }
}
