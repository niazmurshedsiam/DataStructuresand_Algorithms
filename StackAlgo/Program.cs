using System;

class Stack
{
    private int maxSize;
    private int top;
    private int[] stackArray;

    public Stack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1; // Initialize top index to -1 (empty stack)
    }

    public void Push(int value)
    {
        if (top < maxSize - 1)
        {
            top++;
            stackArray[top] = value;
            Console.WriteLine($"Pushed {value} onto the stack.");
        }
        else
        {
            Console.WriteLine("Stack is full. Cannot push.");
        }
    }

    public int Pop()
    {
        if (top >= 0)
        {
            int poppedValue = stackArray[top];
            top--;
            Console.WriteLine($"Popped {poppedValue} from the stack.");
            return poppedValue;
        }
        else
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return -1; // Return a sentinel value to indicate failure
        }
    }

    public int Peek()
    {
        if (top >= 0)
        {
            int peekedValue = stackArray[top];
            Console.WriteLine($"Peeked at {peekedValue} on top of the stack.");
            return peekedValue;
        }
        else
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return -1; // Return a sentinel value to indicate failure
        }
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(30);

        int poppedValue = stack.Pop();
        Console.WriteLine($"Popped value: {poppedValue}");

        int peekedValue = stack.Peek();
        Console.WriteLine($"Peeked value: {peekedValue}");

        Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");
        Console.WriteLine($"Is stack full? {stack.IsFull()}");
    }
}
