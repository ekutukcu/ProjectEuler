using System;

namespace ProjectEuler
{
    public class SmallestMultiple
    {
        public static int FindSmallestNumberDivisableByAllNumbersToLimit(int maxFactor)
        {
            for(int i=2; i<=int.MaxValue; i++)
            {
                bool isDivisable = true;
                for(int j=2; j<maxFactor;j++)
                {
                    if(i%j!=0)
                    {
                        isDivisable=false;
                    }
                }
                if(isDivisable)
                {
                    return i;
                }
            }

            throw new IndexOutOfRangeException();
        }

    }
}
