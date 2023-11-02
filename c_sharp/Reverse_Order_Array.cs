using System;
using System.CodeDom.Compiler;

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5, 6 };

        int[] frequencies = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 1;

            // Check if this element has already been counted
            if (frequencies[i] == -1)
                continue;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    frequencies[j] = -1; // Mark the element as counted
                }
            }

            frequencies[i] = count;
        }

        Console.WriteLine("Element frequencies:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (frequencies[i] != -1)
            {
                Console.WriteLine($"Element {arr[i]}: {frequencies[i]} times");
            }
        }
    }
}
