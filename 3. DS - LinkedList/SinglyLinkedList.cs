using System;

public class Node
{
    public int value { get; set; }
    public Node next { get; set; }

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}

public class LinkedList
{
    private Node head;
    private Node tail;
    private int length;

    public LinkedList(int value)
    {
        this.head = new Node(value);
        this.tail = this.head;
        this.length = 1;
    }

    public void append(int value)
    {
        Node newNode = new Node(value);
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }

    public void prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
    }

    public void insert(int index, int value)
    {
        index = wrapIndex(index);
        if (index == 0)
        {
            prepend(value);
            return;
        }

        if (index == length - 1)
        {
            append(value);
            return;
        }

        Node newNode = new Node(value);

        Node leader = traverseToIndex(index - 1);
        Node holdingPointer = leader.next;

        leader.next = newNode;
        newNode.next = holdingPointer;
        this.length++;

    }

    public void remove(int index)
    {
        index = wrapIndex(index);
        if (index == 0)
        {
            head = head.next;
            return;
        }

        Node leader = traverseToIndex(index - 1);
        Node nodeToRemove = leader.next;
        leader.next = nodeToRemove.next;
        this.length--;
    }

    public void reverse()
    {
        Node first = head;
        tail = head;
        Node second = first.next;
        for (int i = 0; i < length - 1; i++)
        {
            Node temp = second.next;
            second.next = first;
            first = second;
            second = temp;
        }
        head.next = null;
        head = first;
    }

    public void printList()
    {
        if (this.head == null)
        {
            return;
        }
        Node current = this.head;
        while (current != null)
        {
            Console.Write("-->" + current.value);
            current = current.next;
        }
        Console.WriteLine();
    }

    public int getLength()
    {
        return this.length;
    }

    public Node getHead()
    {
        return this.head;
    }

    public Node getTail()
    {
        return this.tail;
    }

    private int wrapIndex(int index)
    { 
        return Math.Max(Math.Min(index, this.length - 1), 0);
    }

    private Node traverseToIndex(int index)
    {
        int counter = 0;
        index = wrapIndex(index);
        Node currentNode = head;
        while (counter != index)
        {
            currentNode = currentNode.next;
            counter++;
        }
        return currentNode;
    }


    static void Main(string[] args)
    {
        LinkedList l = new LinkedList(10);
        l.append(5);
        l.append(16);
        l.prepend(1);
        l.insert(2, 99);
        l.insert(20, 7);
        l.remove(2);
        l.reverse();
        l.printList();
    }
}