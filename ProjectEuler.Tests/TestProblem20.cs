using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class TestProblem20
    {

        [TestMethod]
        public void Test_Problem20()
        {
            var problem20Runner = new Problem20();
            Assert.AreEqual(27,problem20Runner.FindDigitSum(10));
        }

        [TestMethod]
        public void Test_Problem20With100()
        {
            var problem20Runner = new Problem20();
            Assert.AreEqual(27, problem20Runner.FindDigitSum(100));
        }
    }
}
