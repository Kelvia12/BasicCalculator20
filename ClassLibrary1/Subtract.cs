using System;
using Operations;

namespace Subtract
{
    public interface ISub
    {
        public dynamic Subtraction(dynamic a, dynamic b);
    }
    public class Sub : ISub
    {
        public dynamic result;

        public dynamic Subtraction(dynamic a, dynamic b)
        {
            result = Operations.Subtraction.Sub(a, b);
            return result;
        }
    }
}
