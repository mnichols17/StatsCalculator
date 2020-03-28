using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    public class Quotient
    {
        private dynamic Result;

        public dynamic Divide(dynamic a, dynamic b)
        {
            Result = MathOperations.Division.Quotient(a, b);
            return Result;
        }

        public dynamic Divide(dynamic arrayList)
        {
            Result = MathOperations.Division.Quotient(arrayList);
            return Result;
        }
    }
}
