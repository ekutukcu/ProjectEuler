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
    public class TestProblem14
    {
        [TestMethod]
        public void Test_FindStartingNumberWithLongestCollatzSequence_1000000AsMaxUpperBound_Returns13()
        {
            var upperBound = 14;
            var problem14Runner = new Problem14();

            var numberOfCores = Environment.ProcessorCount;

            var results = new (int, int)[numberOfCores];

            Parallel.For(0, numberOfCores, (threadId) =>
              {
                  int classWidth =(int) Math.Round(1000000d / numberOfCores, MidpointRounding.ToPositiveInfinity);
                  results[threadId]=problem14Runner.FindStartingNumberWithLongestCollatzSequence(classWidth * threadId, classWidth * (threadId + 1));
              });

            var result = results.OrderByDescending(x => x.Item2).First().Item1;
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test_FindStartingNumberWithLongestCollatzSequence_14AsMaxUpperBound_Returns9 ()
        {
            var upperBound = 14;
            var problem14Runner = new Problem14();
            Assert.AreEqual(9, problem14Runner.FindStartingNumberWithLongestCollatzSequence(0,10).Item1);
        }

        [TestMethod]
        public void TestProblem15()
        {
            BigInteger x = 1;
            for(int i=0;i<1000;i++)
            {
                x *= 2;
            }
            var stringOfNumber = x.ToString();
            long sumOfDigits = 0;
            for(int i =0; i<stringOfNumber.Length;i++)
            {
                var digit = int.Parse(stringOfNumber.Substring(i,1));
                sumOfDigits += digit;
            }
            Assert.AreEqual(2, sumOfDigits);
        }
    }
}
