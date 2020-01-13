using System;
using Operations;

namespace Squared
{
    public interface ISquared
    {
        public dynamic Squared(dynamic a);
    }
    public class Squares : ISquared
    {
        public dynamic result;

        public dynamic Squared(dynamic a)
        {
            result = Square.Sqr(a);
            return result;
        }
    }
}
