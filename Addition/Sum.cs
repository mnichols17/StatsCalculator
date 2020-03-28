using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace Addition
{
    public class Sum
    {
        private dynamic Result;

        public dynamic Add(dynamic a, dynamic b)
        {
            Result = MathOperations.Addition.Sum(a, b);
            return Result;
        }

        public dynamic Add(dynamic arrayList)
        {
            Result = MathOperations.Addition.Sum(arrayList);
            return Result;
        }
    }
}