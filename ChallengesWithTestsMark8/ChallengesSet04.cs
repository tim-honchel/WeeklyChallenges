using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number % 2 == 0 ? number : -number;
            }
            return sum;
                
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2),Math.Min(number3, number4));
        }

        public Business ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            return biz;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sides = new List<int>() { sideLength1, sideLength2, sideLength3 };
            sides.Sort();

            int shortSide = sides[0];
            int middleSide = sides[1];
            int longSide = sides[2];

            if (shortSide <= 0) { return false; }
            else if (longSide >= shortSide + middleSide) { return false; }
            else { return true; }
        }

        public bool IsStringANumber(string input)
        {
            if (input != null)
            {
                try
                {
                    Convert.ToDouble(input);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else { return false; }
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            double count = objs.Length;
            double num = objs.Where(x => x == null).Count();
            return num / count > .5 ? true : false;

        }
        

        public double AverageEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).DefaultIfEmpty(0).Average();
        }

        public int Factorial(int number)
        {
            if (number <= 0) { throw new ArgumentOutOfRangeException(); }
            else
            {
                int factorial = 1;
                for (int i = number; i > 0; i--)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
