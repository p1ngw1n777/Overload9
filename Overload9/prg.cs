using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload9
{
    public class prg
    {
        public int OPTA(int a) // перегрузка 1
        {
            return a;
        }

        public int OPTA(int a, int b) // перегрузка 2
        {
            return a + b;
        }

        public int OPTA(int a, int b, int c) // перегрузка 3
        {
            return a + b + c;
        }

        public int OPTA(int a, int b, int c, int d) // перегрузка 4
        {
            return a + b + c + d;
        }
    }
}
