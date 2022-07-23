using System;
using System.Collections.Generic;

namespace atlab
{
    public class Calculator
    {
        public List<int> NumberRange = new List<int>();

        public int Sum(int a, int b) 
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public double SumDouble(double a, double b) 
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }




        /// <summary>
        /// Takes a min and max input values.
        /// </summary>
        /// <param name="min">Minimum range</param>
        /// <param name="max">Max range</param>
        /// <returns>The range of Odd Numbers between inputs.</returns>
        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }
    }
}
