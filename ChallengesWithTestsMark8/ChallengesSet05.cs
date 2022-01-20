using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i >0; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }     
            }
            return 0;
        }

        public Business[] ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
                
            }
            return businesses;
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            { 
                var previous = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < previous)
                    {
                        return false;
                    }
                    previous = numbers[i];
                }
                return true;
            }
            return false;
            
            /*var numbersList = numbers.ToList();
            var ascending = numbersList.OrderBy(x => x);
            return ascending == numbersList ? true : false;*/
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                var previous = numbers[0] % 2;
                var sum = 0;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (previous == 0)
                    {
                        sum += numbers[i];
                    }
                    previous = numbers[i] % 2;
                }
                return sum;
            }
            return 0;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words != null && words.Length > 0)
            {
                foreach (var word in words)
                {
                    if (word.Trim() != "")
                    {
                        sentence += " " + word.Trim();
                    }
                }
                if (sentence != "")
                {
                    sentence += ".";
                }
                
            }
            return sentence.TrimStart();
        }
        /*public double[] GetEveryFourthElement(List<double> elements)
        {
            return null;
        }
        */
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements != null && elements.Count > 0)
            {
                var list = new List<double>();
                var counter = 1;
                for (int i = 0; i < elements.Count; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        list.Add(elements[i]);
                    }
                    counter++;
                }
                var answer = list.ToArray();

                return answer;
            }
            return new double[] { };

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber && i !=j)
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }
    }
}
