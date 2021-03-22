using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class TestProblem17
    {
        [TestMethod]
        public void Test_Problem17_Units()
        {
            Assert.AreEqual(3, new Problem17().GetLetterCount(1));
            Assert.AreEqual(5, new Problem17().GetLetterCount(3));
            Assert.AreEqual(4, new Problem17().GetLetterCount(9));
        }
        [TestMethod]
        public void Test_Problem17_Teens()
        {
            Assert.AreEqual(7, new Problem17().GetLetterCount(16));
            Assert.AreEqual(6, new Problem17().GetLetterCount(11));
        }
        [TestMethod]
        public void Test_Problem17_Tens()
        {
            Assert.AreEqual(10, new Problem17().GetLetterCount(67));
            Assert.AreEqual(10, new Problem17().GetLetterCount(53));
            Assert.AreEqual(9, new Problem17().GetLetterCount(31));
            Assert.AreEqual(12, new Problem17().GetLetterCount(77));
        }
        [TestMethod]
        public void Test_Problem17_Hundreds()
        {
            Assert.AreEqual(10, new Problem17().GetLetterCount(100));
            Assert.AreEqual(23, new Problem17().GetLetterCount(135));
            Assert.AreEqual(23, new Problem17().GetLetterCount(672));
            Assert.AreEqual(24, new Problem17().GetLetterCount(781));
            Assert.AreEqual(24, new Problem17().GetLetterCount(999));
            Assert.AreEqual(12, new Problem17().GetLetterCount(800));
            Assert.AreEqual(20, new Problem17().GetLetterCount(430));
            Assert.AreEqual(21, new Problem17().GetLetterCount(811));
            Assert.AreEqual(23, new Problem17().GetLetterCount(342));
            Assert.AreEqual(20, new Problem17().GetLetterCount(115));
        }
        [TestMethod]
        public void Test_Problem17_Thousand()
        {
            Assert.AreEqual(11, new Problem17().GetLetterCount(1000));
        }
        [TestMethod]
        public void Test_Problem17_Numbers1_5()
        {
            int letterCount = 0;
            var problem17Solver = new Problem17();
            for (int i = 1; i <= 5; i++)
            {
                letterCount += problem17Solver.GetLetterCount(i);
            }
            Assert.AreEqual(19, letterCount);
        }
        [TestMethod]
        public void Test_Problem17_Numbers1_10()
        {
            int letterCount = 0;
            var problem17Solver = new Problem17();
            for (int i = 1; i <= 10; i++)
            {
                letterCount += problem17Solver.GetLetterCount(i);
            }
            Assert.AreEqual(39, letterCount);
        }
        [TestMethod]
        public void Test_Problem17_Numbers1_1000()
        {
            int letterCount = 0;
            var problem17Solver = new Problem17();
            for (int i = 1; i <= 1000; i++)
            {
                letterCount += problem17Solver.GetLetterCount(i);
            }
            Assert.AreEqual(19, letterCount);
        }
    }
}
