public static class Kata
{
    static readonly int[] myNums = new int[] { 1, 2, 2 };
    public static void Main()
    {
        Console.WriteLine(SquareSum(myNums));
        Console.WriteLine(SquareSumLINQ(myNums));
        Console.WriteLine(SquareSumMathPow(myNums));
    }
    public static int SquareSum(int[] numbers)
    {
        // Initialize sum as 0
        int sum = 0;

        foreach (int num in numbers)
        {
            // Square a number by multiplying it by itself.
            sum += num * num;
        }

        return sum;
    }

    // Using Lambda expressions + LINQ
    public static int SquareSumLINQ(int[] numbers)
    {
        int sum = numbers.Sum(i => i * i);

        return sum;
    }

    // Using Math.pow + Lambda + LINQ
    public static int SquareSumMathPow(int[] numbers)
    {
        // With Math.Power we have to type cast to int, because it expects a double.
        // int sum = numbers.Select(i => (int)Math.Pow(i, 2)).Sum(); // This works, Selects, maps each element, Sum returns the sum of all elements, its more verbose than the version above
        int sum = numbers.Sum(i => (int)Math.Pow(i, 2));

        return sum;
    }
}