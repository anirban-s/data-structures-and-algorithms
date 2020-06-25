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

class Queue
{
    public Node first;
    public Node last;
    public int length;

    public Queue()
    {
        this.first = null;
        this.last = null;
        this.length = 0;
    }

    public int peek()
    {
        if (this.length > 0)
        {
            return this.first.value;
        }
        return -111111;  //returining large negative value if length is 0.
    }

    public void enqueue (int value)
    {
        Node newNode = new Node(value);
        if (this.length == 0)
        {
            this.first = newNode;
            this.last = newNode;
        }
        else
        {
            this.last.next = newNode;
            this.last = newNode;
        }
        this.length++;
    }

    public int dequeue()
    {
        if (this.first == null)
        {
            return -1111111;
        }
        if (this.length == 0)
        {
            this.last = null;
        }
        Node holdingPointer = this.first;
        this.first = this.first.next;

        this.length--;

        return holdingPointer.value;
    }

    public void printQueue() 
    {
        if(first == null) {
          return;
        }
        Node currentNode = first;
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
        Queue q = new Queue();
        q.enqueue(10);
        q.enqueue(7);
        q.enqueue(26);
        q.printQueue();
        Console.WriteLine(q.dequeue());
        q.printQueue();
    }
}