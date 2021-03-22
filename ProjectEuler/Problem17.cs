using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem17
    {
        private readonly Dictionary<int, string> units = new Dictionary<int, string>
        {
            { 1,"one" },
            { 2,"two" },
            { 3,"three" },
            { 4,"four" },
            { 5,"five" },
            { 6,"six" },
            { 7,"seven" },
            { 8,"eight" },
            { 9,"nine" },
        };

        private readonly Dictionary<int, string> teens = new Dictionary<int, string>
        {
            { 10,"ten" },
            { 11,"eleven" },
            { 12,"twelve" },
            { 13,"thirteen" },
            { 14,"fourteen" },
            { 15,"fifteen" },
            { 16,"sixteen" },
            { 17,"seventeen" },
            { 18,"eighteen" },
            { 19,"nineteen" },
        };

        private readonly Dictionary<int, string> tens = new Dictionary<int, string>
        {
            { 20,"twenty" },
            { 30,"thirty" },
            { 40,"forty" },
            { 50,"fifty" },
            { 60,"sixty" },
            { 70,"seventy" },
            { 80,"eighty" },
            { 90,"ninety" },
        };

        private string hundred = "hundred";
        private string andstring = "and";

        public int GetLetterCount(int number)
        {
            var letters = GetLetters(number);
            return letters.Length;
        }

        private string GetLetters(int number)
        {
            if (number == 0)
                return "";

            string letters = number switch
            {
                < 10 => units[number],
                >= 10 and < 20 => teens[number],
                >= 20 and < 100 => tens[(number - number % 10)] + (number%10==0 ? "": units[number % 10]),
                >= 100 and < 1000 => units[(number - number % 100) / 100 ] + hundred + (number % 100 == 0 ? "" : andstring + GetLetters(number % 100)),
                1000 => "onethousand",
                _ => throw new NotImplementedException()
            };

            return letters;
        }

    }
}
