using System;
using Operations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Difference(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;

        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Sub(a, b);
            return result;
        }
    }
}
