using System;
using System.Collections.Generic;

class UniquePrinter
{
    private HashSet<int> uniqueElements;

    public UniquePrinter()
    {
        uniqueElements = new HashSet<int>();
    }

    public void AddElement(int num)
    {
        uniqueElements.Add(num);
    }

    public void PrintUniqueElements()
    {
        Console.WriteLine("Unique elements in the array:");
        foreach (int element in uniqueElements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 1, 2, 4, 5, 6, 7, 8, 9, 9 };

        UniquePrinter printer = new UniquePrinter();
        foreach (int num in array)
        {
            printer.AddElement(num);
        }

        printer.PrintUniqueElements();
    }
}