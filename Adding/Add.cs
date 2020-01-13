using System;
using Operations;

namespace Adding
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Adding : IAdd
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Operations.Addition.Sum(a, b);
            return result;
        //}

        //public dynamic Add(dynamic a)
        //{
            result = Operations.Addition.Sum(a);
            return result;
       // }

        //public dynamic Sum(dynamic a, dynamic b)
        //{
            //throw new NotImplementedException();
        }
    }
}
