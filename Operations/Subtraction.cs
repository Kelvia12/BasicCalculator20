using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace Operations
{
    public class Subtraction
    {
        public static int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public static double Sub(double a, double b)
        {
            double c = a - b;
            return c;
        }
        public static int Sub(int[] arrayA)
        {
            int c = 0;
            foreach (int a in arrayA)
            {
                c = Sub(a, c);
            }
            return c;
        }

    }
}
