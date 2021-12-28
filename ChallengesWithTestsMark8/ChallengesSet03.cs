using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
   
    
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers == null ? false : (Math.Abs(numbers.Where(x => Math.Abs(x) % 2 == 1).Sum(x => x)) % 2 == 1);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            List<char> numbers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> uppers = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            List<char> lowers = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int num = 0;
            int up = 0;
            int low = 0;

            foreach (char character in password)
            {
                if (numbers.Contains(character)) { num++; }
                if (uppers.Contains(character)) { up++; }
                if (lowers.Contains(character)) { low++; }
            }
            return num > 0 && up > 0 && low > 0 ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            try { return dividend / divisor; }
            catch (Exception) { return 0; }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.LastOrDefault() - nums.FirstOrDefault();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                list.Add(i);
            }

            return list.ToArray();

        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
            return words;
            
        }
    }
}
