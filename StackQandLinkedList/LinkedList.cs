using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQandLinkedList
{
    public class LinkedList
    {
        Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public Node CreateNode(int value)
        {
            Node newnode = new Node(value);
            return newnode;
        }

        public void InsertElement(int value)
        {
            Node newNode = CreateNode(value);

            if (head == null)
            {
                head = newNode;
            }

            Node currNode = this.head;

            while (currNode.next != null)
            {
                currNode = currNode.next;
            }

            currNode.next = newNode;
        }

        public void InserElementAtHead(int value)
        {
            Node newNode = CreateNode(value);

            if (head == null)
            {
                head = newNode;
            }

            newNode.next = head;
            head = newNode;
        }

    }
}
