using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2520, SmallestMultiple.FindSmallestNumberDivisableByAllNumbersToLimit(10));
        }
    }
}
