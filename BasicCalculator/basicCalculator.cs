using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;
using Addition;
using Subtraction;
using Division;
using Multiplication;
using Exponentiation;
using Radical;

namespace BasicCalculator
{
    public class BasicCalculator
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Sum Addition = new Sum();
        Difference Subtraction = new Difference();
        Quotient Division = new Quotient();
        Product Multiply = new Product();
        Power Exponent = new Power();
        Root Rad = new Root();

        public dynamic Add(dynamic a, dynamic b)
        {
            Result = Addition.Add(a, b);
            return Result;
        }

        public dynamic Add(dynamic arrayList)
        {
            Result = Addition.Add(arrayList);
            return Result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;
        }

        public dynamic Subtract(dynamic arrayList)
        {
            Result = Subtraction.Subtract(arrayList);
            return Result;
        }

        public dynamic Divide(dynamic dividend, dynamic divisor)
        {
            Result = Division.Divide(dividend, divisor);
            return Result;
        }
        public dynamic Divide(dynamic arrayList)
        {
            Result = Division.Divide(arrayList);
            return Result;
        }

        public dynamic Multiplication(dynamic a, dynamic b)
        {
            Result = Multiply.Multiply(a, b);
            return Result;
        }

        public dynamic Multiplication(dynamic arrayList)
        {
            Result = Multiply.Multiply(arrayList);
            return Result;
        }

        public dynamic Exponentiation(dynamic a, dynamic b)
        {
            Result = Exponent.Exponent(a, b);
            return Result;
        }

        public dynamic Radical(dynamic a, dynamic b)
        {
            Result = Rad.ansRoot(a, b);
            return Result;
        }

    }


}
