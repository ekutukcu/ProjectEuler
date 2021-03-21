using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class TestProblem12
    {
        [TestMethod]
        public void Test_FindTriangleNumberWithNFactors_5Factors_Returns28()
        {
            var problem12Runner = new Problem12();
            var triangleNumberWith5Factors = problem12Runner.FindTriangleNumberWithNFactors(5);

            Assert.AreEqual(28, triangleNumberWith5Factors);
        }

        [TestMethod]
        public void Test_FindTriangleNumberWithNFactors_500Factors_Returns28()
        {
            var problem12Runner = new Problem12();
            var triangleNumberWith5Factors = problem12Runner.FindTriangleNumberWithNFactors(500);

            Assert.AreEqual(76576500, triangleNumberWith5Factors);
        }
    }
}
