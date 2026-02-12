using static System.Console;
using System.Collections.Generic;

// We want to remove duplicates
// Sort the array

int[] test1 = { 1, 3, 1 };
int[] test2 = { 5, 7, 5, 9, 7 };
int[] test3 = { 1, 9, 3, 1, 7, 4, 6, 6, 7 };

WriteLine(removeDupesAndSort(test1));
WriteLine(removeDupesAndSort(test2));
WriteLine(removeDupesAndSort(test3));

long removeDupesAndSort(int[] a)
{
    Array.Sort(a); // Sorts the array

    List<int> result = new List<int>(); // A list can dynamically grow/shrink in size
    // int[] result = new int[a.Length]; // A normal array wont work because it must be initiated with a fixed size

    for (int i = 0; i < a.Length; i++)
    {
        if (!result.Contains(a[i]))
        {
            result.Add(a[i]);
        }
    }

    return long.Parse(string.Join("", result));
}