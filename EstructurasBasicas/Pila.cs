using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasBasicas
{
    public class Pila
    {
        private int[] elements;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Pila(int size)
        {
            count = 0;
            elements = new int[size];
        }

        public bool Push(int newElement)
        {
            if (count < elements.Length)
            {
                //count++ primero devuelve count y luego le suma 1
                //++count primero suma 1 y luego devuelve count
                elements[count++] = newElement;              
                return true;
            }
            return false;
        }

        public int Top()
        {
            return count > 0 ? elements[count - 1] : 0;
        }

        public int Pop()
        {
            return count > 0 ? elements[--count] : 0;            
        }
    }
}
