using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {

        

        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            var list = new List<int> { };
            return GetNaturalNumbers(list, 1, n);
    }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {

            
            if(max == current)
            {
                naturalNumbers.Add(current);
            }
            else
            {
                naturalNumbers.Add(max);
                GetNaturalNumbers(naturalNumbers, current, max - 1);
            }
            return naturalNumbers;
        }

        public int SumNaturalNumbers(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else {
                return n + SumNaturalNumbers(n-1);
            }
         }

        private int ComputeSum(int min, int current)
        {
            if (min == current)
            {
                return min;
            }
            else
            {
                return current + ComputeSum(min , current - 1);
            }
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n,2);
        }


        private bool IsPrime(int n, int current)
        {           
            // Base cases 
            if (n <= current)
                return (n == current) ? true : false;
            if (n % current == 0)
                return false;
            if (current * current > n)
                return true;

            // Check for next divisor 
            return IsPrime(n, current + 1);
        }

        public bool IsPalindrome(string text)
        {
            int n = text.Length;

            // An empty string is  
            // considered as palindrome 
            if (n == 0)
                return true;

            return IsPalindromeRec(text, 0, n - 1);
        }
        bool IsPalindromeRec(String str,
              int s, int e)
        {
            // If there is only one character 
            if (s == e)
                return true;

            // If first and last 
            // characters do not match 
            if (str[s] != str[e])
                return false;

            // If there are more than  
            // two characters, check if  
            // middle substring is also  
            // palindrome or not. 
            if (s < e + 1)
                return IsPalindromeRec(str, s + 1, e - 1);

            return true;
        }
    }
}
