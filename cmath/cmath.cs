using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmath
{
    public class Cmath
    {
        public int pbadd(int x, int y)
        {
            return x + y;
        }

        private int prsub(int x, int y)
        {
            return x - y;
        }

        protected int promul(int x, int y)
        {
            return x * y;
        }

        internal int Idiv(int x, int y)
        {
            return x / y;
        }

        protected internal int pimod(int x, int y)
        {
            return x % y;
        }
    }
}
