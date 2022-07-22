using System;

namespace atlab
{
    public class Calculator
    {
        public int Sum(int a, int b) 
        {
            return a + b;
        }
        
        public double SumDouble(double a, double b) 
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }
    }
}
