using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{

    class Node
    {
        int data; // data being stored in the node
        Node next; // a reference to the next node
        public Node Next { get { return next; } set { next = value; } }
        public int Data { get { return data; } set { data = value; } }
    }
    class SuperQueue
    {

        Node firstNode; //points to first node of list
        Node lastNode; //points to last node of list
        int count;
        public SuperQueue()
        {
            count = 0;
        }

        public bool Queue(int newElement)
        {

            if (newElement < 0 || newElement > 100)
                return false;

            // A node to add
            Node newNode = new Node();
            newNode.Data = newElement;

            //Trivial Case
            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = firstNode;
                firstNode.Next = lastNode;
            }
            else // a normal day...
            {
                lastNode.Next = newNode;
                lastNode = newNode; // we just update our reference to the last node. I'm assumming first node or the previous node doesn't lose its reference to the next node...
                //lastNode.Next = firstNode; // This is because i think we loose this reference.
            }
            count++;
            return true;
        }

        public int Dequeue()
        {
            if(count != 0)
            {
                int t = firstNode.Data;
                firstNode = firstNode.Next;
                count--;
                return t;
            }
            return -1;
        }

        public int Count
        {
           get { return count; }
        }
    }
}
