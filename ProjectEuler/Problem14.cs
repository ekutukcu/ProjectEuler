using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem14
    {
        public (int,int) FindStartingNumberWithLongestCollatzSequence(int lowerBound,int upperBound)
        {
            int maxSequenceLength = 0;
            int bestStartingNumber = 0;
            Dictionary<int, int> numberToStepsRemainingMapping = new();

            for(int i=lowerBound;i<upperBound;i++)
            {
                if (i <= 1)
                    continue;
                var numberToCheck = i;
                int lengthOfSequence = 1;
                while(numberToCheck != 1)
                {
                    //if(numberToStepsRemainingMapping.ContainsKey(numberToCheck))
                    //{
                    //    lengthOfSequence += numberToStepsRemainingMapping[numberToCheck];
                    //    numberToStepsRemainingMapping.Add(i, lengthOfSequence);
                    //    break;
                    //}
                    if(numberToCheck % 2==0)
                    {
                        numberToCheck = numberToCheck / 2;
                    }
                    else
                    {
                        numberToCheck = 3 * numberToCheck + 1;
                    }
                    lengthOfSequence++;
                }
                if(lengthOfSequence>maxSequenceLength)
                {
                    bestStartingNumber = i;
                    maxSequenceLength = lengthOfSequence;
                }
            }

            return (bestStartingNumber,maxSequenceLength);
        }
    }
}
