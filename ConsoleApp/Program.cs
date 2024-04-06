// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        PrintHeart();
        Console.WriteLine();
        PrintTree(5); // Adjust the parameter to change the size of the tree
        Console.WriteLine();
        PrintLadder(5); // Adjust the parameter to change the size of the ladder
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
}
