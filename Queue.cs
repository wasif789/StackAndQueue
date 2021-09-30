using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class QueueNode<T>
    {
        public T value;
        public QueueNode<T> Next;
        public QueueNode(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class Queue<T>
    {
        QueueNode<T> front;
        //Enqueue method insert the node at the end of list
        public void Enqueue(T value)
        {
            QueueNode<T> node = new QueueNode<T>(value);
            if (front == null)
            {
                front = node;
            }
            //iterate till the last node and insert at the last
            else
            {
                QueueNode<T> rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = node;
            }
        }
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("No element to dequeue");
            }
            else
            {
                QueueNode<T> temp = front;
                front = front.Next;
                temp.Next = null;
            }
        }
        public void display()
        {
            if (front == null)
            {
                Console.WriteLine("No element in stack");
            }
            else
            {
                QueueNode<T> temp = front;
                while (temp != null)
                {
                    Console.WriteLine("{0}", temp.value);
                    temp = temp.Next;
                }
            }
        }
    }
}
