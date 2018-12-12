using NUnit.Framework;

namespace Tests
{
    public class CombinationFixture
    {
        public enum ExampleEnum
        {
            Yes,
            No,
            Maybe
        }

        static int[] Numbers = {0, -1, 10, 9};

        [Test]
        [Pairwise]
        public void CombinationExample([Values] ExampleEnum enumValue, [ValueSource(nameof(Numbers))] int number, [Values] bool flag)
        {
            Assert.Pass();
        }


        [Test]
        public void RangesAndRandoms([Values] ExampleEnum enumValue, [Range(0, 10)] int number, [Random(0.10, 0.99, 3)] decimal random)
        {
            Assert.Pass();
        }
    }
}