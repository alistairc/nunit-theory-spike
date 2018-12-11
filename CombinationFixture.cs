using NUnit.Framework;

namespace Tests
{
    public class CombinationFixture
    {
        public enum ExampleEnum {
            Yes,
            No,
            Maybe
        }

        [Test]
        public void CombinationExample([Values] ExampleEnum enumValue, [Values(0,-1,10)] int number) {
            Assert.Pass();
        }
    }
}