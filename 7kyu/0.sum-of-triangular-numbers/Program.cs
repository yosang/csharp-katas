public class Kata
{
    public static void Main()
    {
        Console.WriteLine(SumTriangularNumbers(-2)); // 0
        Console.WriteLine(SumTriangularNumbers(4)); // 20
        Console.WriteLine(SumTriangularNumbers(6)); // 56

        // Console.WriteLine(SumTriangularNumbersMath(-2)); // 0
        // Console.WriteLine(SumTriangularNumbersMath(4)); // 20
        // Console.WriteLine(SumTriangularNumbersMath(6)); // 56
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

    // public static int SumTriangularNumbersMath(int n)
    // {
    //     return n < 0 ? 0 : n * (n + 1) * (n + 2) / 6;
    // }
}