namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class SumOfSquaresCalculatorTest
{
    [Test]
    public void T1()
    {
        int a = 7;
        int b = 12;

        // Expected: sum of squares from 7 to 12
        int expected = 0;
        for (int i = a; i <= b; i++)
        {
            expected += i * i;
        }

        int actual = SumOfSquaresCalculator.CalculateSumOfSquares(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}