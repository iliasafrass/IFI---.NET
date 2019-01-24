using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {

            int i = 1;
            var list = new List<int> { };

            if (i == 1)
            {
                list.Add(1);
            }
            else {
                list.Add(n);
                GetNaturalNumbers(n - 1);
            }
            return list;
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {

            var list = new List<int> { };
            int i = current;

            if(i == current)
            {
                naturalNumbers.Add(i);
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
            int i = 1;
            int somme = 0;

            while (i < n+1) {
                somme += i;
                i++;
            }
            return somme;
        }

        private int ComputeSum(int min, int current)
        {
            int somme = 0;
            for (int i = min; i < current; i++) {
                   
            }
            return 0;
        }

        public bool IsPrime(int n)
        {
            throw new NotImplementedException();
        }

        private bool IsPrime(int n, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome(string text)
        {
            throw new NotImplementedException();
        }
    }
}
