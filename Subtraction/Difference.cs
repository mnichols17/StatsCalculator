using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace Subtraction
{
    public class Difference
    {
        private dynamic Result;

        public dynamic Subtract(dynamic a, dynamic b)
        {
            Result = MathOperations.Subtraction.Difference(a, b);
            return Result;
        }

        public dynamic Subtract(dynamic arrayList)
        {
            Result = MathOperations.Subtraction.Difference(arrayList);
            return Result;
        }
    }
}
