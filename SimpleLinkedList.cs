using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14LinkedLst
{
    public class LinkedList
    {
        private int size;
        private Node head;

        public LinkedList()
        {
            this.size = 0;
            this.head = null;
        }

        /**
         * Inserting new node at the end of the linked list
         * 
         * @param data - represent the node data to be added to the linked list
         */
        public void insertNode(int data)
        {
            Node node = new Node();
            node.data = data;
            Node current = this.head;

            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
                this.size = 1;
                Console.WriteLine(this.head);
            }
            else
            {

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                node.next = null;
                this.size += 1;
            }
        }
        
        public void insertNth(int data, int position)
        {
            Node node = new Node();
            node.data = data;
            Node current = this.head;
            if (this.head != null && position <= this.size)
            {
                for (int i = 1; i < position; i++)
                {
                    current = current.next;
                }
                node.next = current.next;
                current.next = node;
                this.size += 1;
            }
            else
            {
                Console.WriteLine("Exceeded the linked list size. Current Size: " + size);
            }
        }
        
        
          public void printNodes()
        {
            if (this.size < 1)
                Console.WriteLine("There are no nodes in the linked list");

        else
            {
                Node current = this.head;
                for (int i = 0; i < this.size; i++)
                {
                    Console.WriteLine("Node " + current.data + " is at location " + i);
                    current = current.next;
                }
            }
        }


            public int getListSize()
        {
            return size;
        }

    }
}
