using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMax()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var comp = Max(list);
            var result = Operations.Max(list);

            Assert.AreEqual(comp, result);

        }
    }
}