using System;
using System.Collections.Generic;

class BreadthFirstSearch
{
    //Iterative
    public static List<int> breathFirstSearch(Node currentNode)
    {
        List<int> list = new List<int>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(currentNode);

        while (queue.Count > 0)
        {
            currentNode = queue.Dequeue();
            list.Add(currentNode.value);
            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }

            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }
        }
        return list;
    }
    //Recurcive
    public static List<int> breathFirstSearchR(Queue<Node> queue, List<int> list)
    {
        if (queue.Count == 0)
        {
            return list;
        }

        var currentNode = queue.Dequeue();
        list.Add(currentNode.value);
        if (currentNode.left != null)
        {
            queue.Enqueue(currentNode.left);
        }

        if (currentNode.right != null)
        {
            queue.Enqueue(currentNode.right);
        }

        return breathFirstSearchR(queue, list);
    }

    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.insert(9);
        tree.insert(4);
        tree.insert(6);
        tree.insert(20);
        tree.insert(170);
        tree.insert(15);
        tree.insert(1);

        var result = breathFirstSearch(tree.root);
        foreach (var item in result)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();

        //Recurcive call
        List<int> list = new List<int>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(tree.root);
        var result2 = breathFirstSearchR(queue, list);
        foreach (var item in result2)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();
    }
}

class Node
{
    public Node left { get; set; }
    public Node right { get; set; }
    public int value { get; set; }

    public Node(int value)
    {
        this.left = null;
        this.right = null;
        this.value = value;
    }
}

class BinarySearchTree
{
    public Node root;
    public BinarySearchTree()
    {
        this.root = null;
    }

    public void insert(int value)
    {
        Node newNode = new Node(value);
        if (this.root == null)
        {
            this.root = newNode;
            return;
        }

        Node currentNode = this.root;
        while (true)
        {
            if (currentNode.value > value)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = new Node(value);
                    return;
                }
                currentNode = currentNode.left;
            }
            else
            {
                if (currentNode.right == null)
                {
                    currentNode.right = new Node(value);
                    return;
                }
                currentNode = currentNode.right;
            }
        }
    }
}