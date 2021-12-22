using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet.Contains(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
           return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (Math.Abs(num) % 2 == 1);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null ? 0 : (numbers.DefaultIfEmpty().Max() + numbers.DefaultIfEmpty().Min());
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (Math.Min(str1.Length, str2.Length));
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.DefaultIfEmpty(0).Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum();
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : Math.Abs(numbers.Sum()) % 2 == 1;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var integer = Convert.ToInt64(number);
            return integer > 1 ? (integer) / 2 : 0;
        }
    }
}
