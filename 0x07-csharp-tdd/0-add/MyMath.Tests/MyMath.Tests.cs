using NUnit.Framework;
using MyMath;

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
        public void TestSum()
        {
            var result = Operations.Add(1, 1);
            Assert.AreEqual(2, result);

            result = Operations.Add(-1, -2);
            Assert.AreEqual(-3, result);

            result = Operations.Add(0, 0);
            Assert.AreEqual(0, result);

            result = Operations.Add(-3, 2);
            Assert.AreEqual(-1, result);

             result = Operations.Add(3, -2);
            Assert.AreEqual(1, result);
        }
    }
}
