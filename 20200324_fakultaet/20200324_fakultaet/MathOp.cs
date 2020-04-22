using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_fakultaet
{
    class MathOp
    {
        public static long Fakultaet(long n)
        {
            checked
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }

                return Fakultaet(n-1)+n;
            }
        }
    }
}