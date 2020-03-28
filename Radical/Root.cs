using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace Radical
{
    public class Root
    {
        private dynamic Result;

        public dynamic ansRoot(dynamic a, dynamic b)
        {
            Result = MathOperations.Radical.rootAns(a, b);
            return Result;
        }
    }
}
