using System;
using Operations;

namespace Divide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Div 
    {
        public dynamic result;

        public double Dividing(dynamic a, dynamic b)
        {
            result = Division.Divide(a, b);
            return result;
        }
    }
}
