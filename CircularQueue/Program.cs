using System;

public class CircularQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int capacity;

    public CircularQueue(int size)
    {
        capacity = size;
        queue = new int[capacity];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int item)
    {
        // Check if the queue is full
        if ((rear + 1) % capacity == front)
        {
            Console.WriteLine("Queue is full. Cannot enqueue.");
            return;
        }

        // If the queue is empty, set front to 0
        if (front == -1)
            front = 0;

        // Increment rear and wrap around if needed
        rear = (rear + 1) % capacity;
        queue[rear] = item;
        Console.WriteLine("Enqueued: " + item);
    }

    public void Dequeue()
    {
        // Check if the queue is empty
        if (front == -1)
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return;
        }

        int item = queue[front];

        // If there's only one element, reset front and rear
        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else
        {
            // Move front forward and wrap around if needed
            front = (front + 1) % capacity;
        }

        Console.WriteLine("Dequeued: " + item);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CircularQueue cq = new CircularQueue(5);
        cq.Enqueue(10);
        cq.Enqueue(20);
        cq.Enqueue(30);
        cq.Enqueue(40);
        cq.Enqueue(50);

        // Queue is full, cannot enqueue
        cq.Enqueue(60);

        cq.Dequeue();
        cq.Dequeue();
        cq.Dequeue();
        cq.Dequeue();
        cq.Dequeue();

        // Queue is empty, cannot dequeue
        cq.Dequeue();
    }
}

