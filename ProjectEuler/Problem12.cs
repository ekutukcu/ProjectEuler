using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem12
    {
		public int FindTriangleNumberWithNFactors(int N)
		{
			var triangleNumbers = GetAllTriangleNumberUpToLimit(1000000);

			Console.WriteLine($"Found {triangleNumbers.Count} numbers");
			int maxDivisorCount = 0;
			int bestNumberFound = 0;
			for (int i = 0; i < triangleNumbers.Count; i++)
			{
				var triangleNumber = triangleNumbers[i];
				var divisorCount = GetDivisorCount(triangleNumber);
				if (divisorCount > maxDivisorCount)
				{
					maxDivisorCount = divisorCount;
					bestNumberFound = triangleNumber;
				}
				if (divisorCount > N)
				{
					bestNumberFound=triangleNumber;
					break;
				}
			}
			return bestNumberFound;
		}


		// You can define other methods, fields, classes and namespaces here

		int GetDivisorCount(int numberToCheck)
		{
			int divisorCount = 0;
			for (int i = 1; i <= numberToCheck / 2; i++)
			{
				if (numberToCheck % i == 0)
				{
					divisorCount++;

				}
			}
			return divisorCount + 1;
		}

		List<int> GetAllTriangleNumberUpToLimit(int N)
		{
			var listOfTriangleNumbers = new List<int>();
			int currentTriangleNumber = 0;
			for (int i = 1; i <= N; i++)
			{
				currentTriangleNumber += i;
				listOfTriangleNumbers.Add(currentTriangleNumber);
			}

			return listOfTriangleNumbers;
		}

	}
}
