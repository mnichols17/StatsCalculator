using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace Exponentiation
{
    public class Power
    {
        private dynamic Result;

        public dynamic Exponent(dynamic a, dynamic b)
        {
            Result = MathOperations.Exponentiaton.Power(a, b);
            return Result;
        }
    }
}
