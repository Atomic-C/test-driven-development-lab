using System;
using System.Collections.Generic;

namespace atlab
{
    public class Calculator
    {
        public List<int> NumberRange = new List<int>();

        /// <summary>
        /// Takes two integer values
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>The Sum between a and b</returns>
        public int Sum(int a, int b) 
        {
            return a + b;
        }

        /// <summary>
        /// Takes two integer values
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>The subtraction between a and b</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Takes two integer values
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>The product between a and b</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        
        /// <summary>
        /// Takes two double values
        /// </summary>
        /// <param name="a">First double</param>
        /// <param name="b">Second double</param>
        /// <returns>The Sum between a and b</returns>
        public double SumDouble(double a, double b) 
        {
            return a + b;
        }
        /// <summary>
        /// Takes a integer as input
        /// </summary>
        /// <param name="a">The number to be evaluated</param>
        /// <returns>true if Odd and false if Even</returns>
        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }
        /// <summary>
        /// Takes a min and max input values.
        /// </summary>
        /// <param name="min">Minimum range</param>
        /// <param name="max">Max range</param>
        /// <returns>The range of Odd Numbers between min and max input</returns>
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
