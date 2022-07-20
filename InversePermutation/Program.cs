using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 5, 1 };
        int size = arr.Length;
        inversePermutation(arr, size);

    }
    static void inversePermutation(int[] arr, int size)
    {
        int i, j;
        // Loop to select Elements one by one
        for (i = 0; i < size; i++)
        {

            // Loop to print position of element
            // where we find an element
            for (j = 0; j < size; j++)
            {

                // checking the element in
                // increasing order
                if (arr[j] == i + 1)
                {
                    // print position of element
                    // where element is in inverse
                    // permutation
                    Console.Write(j + 1 + " ");
                    break;
                }
            }
        }
    }
}
