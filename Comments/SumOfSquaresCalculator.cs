namespace Comments;

public class SumOfSquaresCalculator
{
    public static int CalculateSumOfSquares(int lowerBound, int upperBound)
    {
        int accumulatedSum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            accumulatedSum += Square(i);
        }

        return accumulatedSum;
    }

    static int Square(int number)
    {
        return number * number;
    }
}