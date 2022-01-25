using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words != null)
            {
                foreach (string w in words)
                {
                    if (w != null)
                    {
                        switch (ignoreCase)
                        {
                            case true:
                                if (w.ToLower() == word.ToLower())
                                {
                                    return true;
                                }
                                break;
                            case false:
                                if (w == word)
                                {
                                    return true;
                                }
                                break;
                        }
                    }

                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    return i;
                }
                
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int maxCount = 1;
            if (numbers.Length < 2)
            {
                maxCount = numbers.Length;
            }
            else
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        count++;
                        maxCount = Math.Max(count, maxCount);
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null)
            {
                return new double[0];
            }

            var list = new List <double>();
            for (int i = n - 1; i < elements.Count(); i+=n)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }
    }
}
