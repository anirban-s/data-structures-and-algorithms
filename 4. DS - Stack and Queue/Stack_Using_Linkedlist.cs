using System;

class Node
{
    public int value { get; set; }
    public Node next { get; set; }

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}

class Stack
{
    public Node top;
    public Node bottom;
    public int length;

    public Stack()
    {
        this.top = null;
        this.bottom = null;
        this.length = 0;
    }

    public int peek()
    {
        if (this.length > 0)
            return this.top.value;
        return -100000; //returning -100000 if length is 0
    }

    public void push(int value)
    {
        Node newNode = new Node(value);
        if (this.length == 0)
        {
            this.top = newNode;
            this.bottom = newNode;
        }
        else
        {
            Node holdingPointer = this.top;
            this.top = newNode;
            this.top.next = holdingPointer;
        }
        this.length++;
    }

    public int pop()
    {
        if (this.top == null)
        {
            return -100000;
        }
        Node holdingPointer = this.top;
        this.top = this.top.next;
        this.length--;
        return holdingPointer.value;
    }

    public void printStack()
    {
        if(top == null) 
        {
            return;
        }
        Node currentNode = top;
        Console.Write(currentNode.value);
        currentNode = currentNode.next;
        while (currentNode != null) {
          Console.Write("-->" + currentNode.value);
          currentNode = currentNode.next;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Stack s = new Stack();
        s.push(10);
        s.push(16);
        s.push(100);
        s.printStack();
        Console.WriteLine(s.pop());
        s.printStack();
    }

}