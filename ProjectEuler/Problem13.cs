using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem13
    {
        public long GetFirst10DigitsOfSum(List<BigInteger> integersToSum)
        {
            BigInteger sumOfIntegers = 0;
            foreach(var integerToSum in integersToSum)
            {
                sumOfIntegers += integerToSum;
            }

            var stringOfSum = sumOfIntegers.ToString();
            
            var first10Digits = stringOfSum.Substring(0,10);
            return long.Parse(first10Digits);
        }
    }
}
