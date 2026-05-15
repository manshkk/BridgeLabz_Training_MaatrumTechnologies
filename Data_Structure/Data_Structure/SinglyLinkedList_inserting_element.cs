using System;

namespace Data_Structure
{
    class SinglyLinkedList
    {
        private Node head;

        // =====================================================
        // 🔹 INSERTION METHODS
        // =====================================================

        // 🔸 1. Insert at Beginning
        public void InsertAtBeginning(int value)
        {
            Node newNode = new Node(value);

            newNode.next = head;
            head = newNode;
        }

        // 🔸 2. Insert at End
        public void InsertAtEnd(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        // 🔸 3. Insert After a Given Node (by value)
        public void InsertAfter(int target, int value)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.data == target)
                {
                    Node newNode = new Node(value);

                    newNode.next = temp.next;
                    temp.next = newNode;
                    return;
                }

                temp = temp.next;
            }

            Console.WriteLine("Node not found");
        }

        // =====================================================
        // 🔹 DISPLAY METHOD (FOR TESTING)
        // =====================================================

        public void Display()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }

            Console.WriteLine("NULL");
        }
    }
}