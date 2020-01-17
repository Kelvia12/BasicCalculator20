using System;
using System.Collections.Generic;
using System.Text;
using Divide;
using Adding;
using Cubed;
using Squared;
using SquareRoot;
using Subtract;
using Multiply;

namespace BasicCalculator
{


    public class Calculator : IAdd, ISubtract, IMultiply, ICubed, ISquareroot
    {
        // Creating objects of Add, Divide, Subtract, Multiply, Squared, Cubed, Squareroot 
        Ad add = new Ad();
        Div divide = new Div();
        Sub subtract = new Sub();
        Multiple multiply = new Multiple();
        Squares square = new Squares();
        Cubes cube = new Cubes();
        Squareroots squareroot = new Squareroots();

        // public dynamic result { get; set; }
        public dynamic result;
        /*public dynamic Result
        {
            get
            {
                string type = result.GetType().ToString();
                if(type == "Int")
                {
                    return result;
                }
                else
                {
                    return Helpers.Rounding.RoundTwoDecimalPlaces(result);
                }
            }
            set
            {
                result = value;
            }
        } */
        /* public dynamic GetResult()
         {
             return result;
         }

         public dynamic SetResult()
         {
             throw new System.Exception("Result Set");

         }*/

        public dynamic Squareroot(dynamic a)
        {
            result = squareroot.Squareroot(a);
            return result;
        }
        public dynamic Cubed(dynamic a)
        {
            result = cube.Cubed(a);
            return result;
        }
        public dynamic Square(dynamic a)
        {
            result =  (a);
            return result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiply.Multiply(a, b);
            return result;
        }
        public dynamic Difference(dynamic a, dynamic b)
        {
            result = subtract.Difference(a, b);
            return result;

        }

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);

            return result;
        }

        public int Add(int[] a)
        {
            result = add.Add(a);

            return result;
        }
        public dynamic Dividing(dynamic a, dynamic b)
        {

            result = divide.Dividing(a, b);
            return result;

        }
    }
}
