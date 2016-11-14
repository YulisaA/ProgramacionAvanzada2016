using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Functions
{
    class Functions
    {
        public static bool Pal(string P)
        {
            if (P.Length == 1)
                return true;
            if (P.Length == 2)
            {
                if (P[0] == P[1])
                    return true;
            }
            if (P[0] == P[P.Length - 1])
                return Pal(P.Substring(1, P.Length - 2));
            else
                return false;
        }


        private static bool Primo(int x, int y)
        {
            if (y == 1)
                return true;
            if (x % y == 0)
                return false;
            return Primo(x, y - 1);
        }


        public static bool Prim(int x)
        {

            return Primo(x, x - 1);

        }


    }
}
