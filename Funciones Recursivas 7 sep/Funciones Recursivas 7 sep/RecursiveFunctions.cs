using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Recursivas_7_sep
{
    class RecursiveFunctions
    {

        public static int Fibonacci(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }



        public static string invertString(string anString, int position)
        {
            if (position == 0)
                return anString[0].ToString();

            return anString[position] +  invertString(anString, position-1);
        }

        public static string borisStyleInvertString(string s)
        {
            if (s.Length == 1)
                return s;

            return s[s.Length - 1] + borisStyleInvertString(s.Substring(0, s.Length-1)); // substring pide startindex, length 
        }

        public static int arrayproduct(int[] anarray, int n)
        {
            if (n == 1)
                return anarray[0];

            return arrayproduct(anarray, (n - 1)) * anarray[n - 1];

        }


        public static int Gxy(int x, int y)
        {
            if (x < y)
            {
                return (2 * x) - y;

            }

            return (1 / Gxy(x - y, x + 1));

        }


    }
}
