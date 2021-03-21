using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
   public  class Problem20
    {
        public long FindDigitSum(int N)
        {
            BigInteger factorial = 1;
            for(int i=1;i<=N;i++)
            {
                factorial *= i;
            }

            var stringOfSum = factorial.ToString();

            long sumOfDigits = 0;
            for(int i=0;i<stringOfSum.Length;i++)
            {
                var digit = stringOfSum.Substring(i, 1);
                sumOfDigits+=long.Parse(digit);
            }
            return sumOfDigits;
        }
    }
}
