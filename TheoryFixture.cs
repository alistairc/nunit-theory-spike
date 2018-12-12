using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class TheoryFixture
    {
        [Datapoint] private int Zero = 0;
        [Datapoint] private int One = 1;
        [Datapoint] private int PositiveFirst = 3;
        [Datapoint] private int PositiveSecond = 5;
        [Datapoint] private int Negative = -10;

        [Datapoints] private int[] SomeMoreInts = {7, 11, 13, 17, 19};

        [DatapointSource]
        [Theory]
        public void MultiplyingIntsIsSameAsRepeatedlyAdding(int first, int second)
        {
            Assume.That(second, Is.GreaterThan(0));

            var sum = Enumerable.Repeat(first, second).Aggregate((acc, x) => acc + x);
            Assert.That(first * second, Is.EqualTo(sum));
        }
    }
}