using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOperations
{
    public class Variance
    {
        public static dynamic Variances(dynamic arrayA, double mean)
        {
            int arraylen = Helpers.Array.ArrayLength(arrayA);
            double[] vArray = new double[arraylen];

            dynamic diffvalue;
            double addedSquares = 0.0;
            int i = 0;
            double vValue = 0.0;
            foreach (double b in arrayA)
            {
                diffvalue = Operations.Subtraction.Sub(b, mean);
                vArray[i] = diffvalue;
                //squaredValue = vValue[i];
                vArray[i] = Operations.Square.Sqr(vArray[i]);
                addedSquares = addedSquares + vArray[i];

                i++;
            }

            vValue = Helpers.Rounding.RoundTwoDecimalPlaces(Operations.Division.Divide(addedSquares, arraylen));
            return vValue;
        }
    }
}
