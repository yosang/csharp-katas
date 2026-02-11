Link to kata: https://www.codewars.com/kata/580878d5d27b84b64c000b51

Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.

Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."

e.g. If `4` is given: `1 + 3 + 6 + 10 = 20`.

**OBS** - Triangular Numbers cannot be negative so return 0 if a negative number is given.

Triangular numbers:

```
[01]
02 [03]
04 05 [06]
07 08 09 [10]
11 12 13 14 [15]
16 17 18 19 20 [21]
```

# Solution

## Mathetmatical forumla
Saves us from loops.

## Sequence using a loop
A triangular number sequence is simply 1, 3, 6, 10, 15, 21, 28, 36, 45, ...

- To do this with a loop we run a loop starting from `1` and all the way up to `n`.
- Triangular numbers are computed by adding the current iteration number to a variable. `t += i`.
- To obtain the sum we can then add `t` to a `sum` variable for each iteration.

```c#
    // First: i=1 + t=0 = 1
    // Second : i=2 + t=1 = 3
    // Third : i=3 + t=3 = 6
    // Fourth : i=4 + t=3 = 10
    int n = 4;
    int t = 0;

    for (int i = 1; i <= n; i++)
    {
        t += i;
        Console.WriteLine(t);
    }
```

## Sum
We create a new variable that sums up computed triangular numbers and return this at the end of the method.

```c#
public class Kata
{
    public static void Main()
    {
        Console.WriteLine(SumTriangularNumbers(-2)); // 0
        Console.WriteLine(SumTriangularNumbers(4)); // 20
        Console.WriteLine(SumTriangularNumbers(6)); // 56
    }

    public static int SumTriangularNumbers(int n)
    {
        if (n < 0) return 0; // Return 0 if a negative number is passed as an argument

        int t = 0; // Stores calculated triangular number
        int sum = 0; // Stores the sum of triangular numbers

        for (int i = 1; i <= n; i++) // run i all the way up top n
        {
            t += i; // computes the current triangular number
            sum += t; // sums up triangular numbers
        }

        return sum;
    }
}
```