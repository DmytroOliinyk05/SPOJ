using System;
public static class ABSP1
{
    public static long Solve(int[] numbers)
    {
        long absoluteDifferencesSum = 0;
        for (int i = 0; i < numbers.Length; ++i)
        {
            int number = numbers[i];
            int smallerNumbersCount = i;
            int largerNumbersCount = numbers.Length - 1 - i;

            absoluteDifferencesSum += (smallerNumbersCount - largerNumbersCount) * (long)number;
        }

        return absoluteDifferencesSum;
    }
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(
                Console.ReadLine().Split(default(char[]), StringSplitOptions.RemoveEmptyEntries),
                int.Parse);

            Console.WriteLine(
                ABSP1.Solve(numbers));
        }
    }
}