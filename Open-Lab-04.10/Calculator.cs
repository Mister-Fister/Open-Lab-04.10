using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float a = 0;
            foreach(int b in nums)
            {
                a = a + b;
            }
            float c = a / nums.Length;
            return c;
        }
    }
}
