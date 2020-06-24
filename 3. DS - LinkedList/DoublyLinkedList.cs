using System;

public class Node
{
    public int value { get; set; }
    public Node next { get; set; }
    public Node previous { get; set; }

    public Node(int value)
    {
        this.value = value;
        this.next = null;
        this.previous = null;
    }
}

public class DoublyLinkedList
{
    private Node head;
    private Node tail;
    private int length;

    public DoublyLinkedList(int value)
    {
        this.head = new Node(value);
        this.tail = this.head;
        this.length = 1;
    }

    public void append(int value)
    {
        Node newNode = new Node(value);
        newNode.previous = this.tail;
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }

    public void prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.next = this.head;
        this.head.previous = newNode;
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
        Node follower = leader.next;

        leader.next = newNode;
        newNode.previous = leader;
        newNode.next = follower;
        follower.previous = newNode;
        
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
        nodeToRemove.next.previous = leader;
        this.length--;
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
        DoublyLinkedList d = new DoublyLinkedList(10);
        d.append(7);
        d.append(16);
        d.prepend(5);
        d.insert(1, 99);
        d.remove(1);

        d.printList();
    }
}