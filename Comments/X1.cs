namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int p = 0;

        // Iterate from lower bound (q) to upper bound (z)
        for (int i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            p += Square(i);
        }

        // Return accumulated sum
        return p;
    }

    static int Square(int number)
    {
        return number * number;
    }
}