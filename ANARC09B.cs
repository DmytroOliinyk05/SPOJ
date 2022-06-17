using System;
public static class ANARC09B
{
    public static long Solve(int tileWidth, int tileHeight)
    {
        int squareWidth = tileHeight / GreatestCommonDivisor(tileWidth, tileHeight);
        int squareHeight = tileWidth / GreatestCommonDivisor(tileWidth, tileHeight);
        return squareWidth * (long)squareHeight;
    }

    private static int GreatestCommonDivisor(int a, int b)
    {
        int temp;
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}

public static class Program
{
    private static void Main()
    {
        int[] line;
        while ((line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse))[0] != 0)
        {
            Console.WriteLine(
                ANARC09B.Solve(line[0], line[1]));
        }
    }
}