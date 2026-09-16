namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class SumOfSquaresCalculatorTest
{
    [Test]
    public void CalculatingSumOfSquaresCalculatesTheSumOfSquares()
    {
        int lowerBound = 7;
        int upperBound = 12;

        int expected = 0;
        for (int i = lowerBound; i <= upperBound; i++)
        {
            expected += i * i;
        }

        int actual = SumOfSquaresCalculator.CalculateSumOfSquares(lowerBound, upperBound);
        Assert.That(actual, Is.EqualTo(expected));
    }
}