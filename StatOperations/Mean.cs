using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOperations
{
    public class StatOperations
    {
        public static object StatOperation { get; set; }

        public static dynamic Mean(dynamic values)
        {
            var sum = Operations.Addition.Sum(values);
            var valueCount = Helpers.Array.ArrayLength(values);
            var result = Operations.Division.Divide(sum, valueCount);
            return result;
        }
    }
}

