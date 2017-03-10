using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Recursivas_7_sep
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {


                Console.WriteLine(" FIBONACCI (para n >= 0  con F(0) = 0 y F(1) = 1) : ");
                Console.Write("Ingrese n: ");
                int n = int.Parse(Console.ReadLine());

                int result = RecursiveFunctions.Fibonacci(n);

                Console.WriteLine("Fibonacci(" + n.ToString() + ") = " + result.ToString());


                Console.WriteLine("\n INVERTIR CADENA: ");
                Console.Write(" Ingrese una cadena:  ");

                string anString = Console.ReadLine();
                //string newString = RecursiveFunctions.invertString(anString, anString.Length - 1);
                string newString = RecursiveFunctions.borisStyleInvertString(anString);


                Console.WriteLine("String invertido: " + newString);

                Console.WriteLine("\n PRODUCTORIA DE UN ARRAY: ");
                Console.Write("Ingrese el tamaño del array:  ");
                int arraySize = int.Parse(Console.ReadLine());

                int[] anArray = new int[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine("Ingrese valor " + i.ToString() + " del array: ");
                    anArray[i] = int.Parse(Console.ReadLine());
                }



                int arrayProduct = RecursiveFunctions.arrayproduct(anArray, anArray.Length);
                Console.WriteLine("Valores del array:\n");
                for (int i = 0; i < anArray.Length; i++)
                {
                    Console.Write("[" + i.ToString() + "] = " + anArray[i].ToString());
                    if (i < anArray.Length - 1)
                        Console.Write(" * ");

                }
                Console.WriteLine("\n PRODUCTO DEL ARRAY:" + arrayProduct.ToString());


                Console.WriteLine("\n FUNCIÓN : G(x,y) = {1 / Gxy(x - y, x + 1) Si x >= y ; (2 * x) - y si x < y ");
                Console.Write("Ingrese x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("\n Ingrese y: ");
                int y = int.Parse(Console.ReadLine());

                int Gxy = RecursiveFunctions.Gxy(x, y);

                Console.WriteLine("G(x,y) result: " + Gxy.ToString());



                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
