using System;

public class QueueExample
{
    private int[] queueArray;
    private int front; // Index of the front element
    private int rear;  // Index of the rear element
    private int capacity;

    public QueueExample(int size)
    {
        capacity = size;
        queueArray = new int[size];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue.");
            return;
        }

        if (front == -1)
            front = 0;

        rear++;
        queueArray[rear] = item;
        Console.WriteLine($"Enqueued: {item}");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return -1; // Return a sentinel value to indicate failure
        }

        int dequeuedItem = queueArray[front];
        front++;

        if (front > rear)
        {
            // Reset front and rear when the queue becomes empty
            front = -1;
            rear = -1;
        }

        Console.WriteLine($"Dequeued: {dequeuedItem}");
        return dequeuedItem;
    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public bool IsFull()
    {
        return rear == capacity - 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        QueueExample queue = new QueueExample(5);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue(); // Attempting to dequeue when the queue is empty

        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.ReadKey();
    }
}

