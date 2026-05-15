using System;
using Data_Structure;

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();

        list.InsertAtBeginning(10);
        list.InsertAtBeginning(5);

        list.InsertAtEnd(20);
        list.InsertAtEnd(30);

        list.InsertAfter(20, 25);

        list.Display();
    }
}
