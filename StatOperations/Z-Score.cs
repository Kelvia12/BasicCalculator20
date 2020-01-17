using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOperations
{
    public class Zscore
    {
        public static double ZScore(dynamic score, dynamic mean, dynamic standiv)
        {
            dynamic zscore = Helpers.Rounding.RoundTwoDecimalPlaces(Operations.Division.Divide((Operations.Subtraction.Sub(score, mean)), standiv));
            return zscore;
        }
    }
}
