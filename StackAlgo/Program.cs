using System;

class Stack
{
    private char[] items;
    private int top;

    public Stack(int size)
    {
        items = new char[size];
        top = -1; // Initialize top index to -1 (empty stack)
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == items.Length - 1;
    }

    public void Push(char value)
    {
        if (!IsFull())
        {
            top++;
            items[top] = value;
        }
        else
        {
            Console.WriteLine("Stack is full. Cannot push.");
        }
    }

    public char Pop()
    {
        if (!IsEmpty())
        {
            char poppedValue = items[top];
            top--;
            return poppedValue;
        }
        else
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return '\0'; // Return a sentinel value to indicate failure
        }
    }
}

class Program
{
    static void ReverseString(char[] str)
    {
        Stack stack = new Stack(str.Length);

        foreach (char ch in str)
        {
            stack.Push(ch);
        }

        for (int i = 0; i < str.Length; i++)
        {
            str[i] = stack.Pop();
        }
    }

    static void Main(string[] args)
    {
        char[] str = "Hello, World!".ToCharArray();
        Console.WriteLine($"Original string: {new string(str)}");

        ReverseString(str);
        Console.WriteLine($"Reversed string: {new string(str)}");
    }
}
