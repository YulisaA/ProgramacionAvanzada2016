using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int number;
            Console.WriteLine("Ingrese una palabra para ver si es palindromo");
            word = Console.ReadLine();
            if (Functions.Pal(word))
            {
               Console.WriteLine("La palabra es palindromo"); 
            }
            else
            {
                Console.WriteLine("La palabra no es palindromo");
            }

            Console.WriteLine("Ingrese un numero para ver si es o no primo");
            number = int.Parse(Console.ReadLine());
            if (Functions.Prim(number))
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero NO es primo");
            }
           
            Console.ReadKey();


        }
    }
}
