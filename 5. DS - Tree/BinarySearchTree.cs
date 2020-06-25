useing System;

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
    private Node root;
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

    public Node lookup(int value)
    {
        if (root == null)
        {
            return null;
        }
        Node currentNode = this.root;
        while (currentNode != null)
        {
            if (value < currentNode.value)
            {
                currentNode = currentNode.left;
            }
            else if (value > currentNode.value)
            {
                currentNode = currentNode.right;
            }
            else
            {
                return currentNode;
            }
        }
        return null;
    }

    public void remove(int value)
    {
        if (root == null)
        {
            return;
        }

        Node nodeToRemove = root;
        Node parentNode = null;
        while (nodeToRemove.value != value)
        { //Searching for the node to remove and it's parent
            parentNode = nodeToRemove;
            if (value < nodeToRemove.value)
            {
                nodeToRemove = nodeToRemove.left;
            }
            else if (value > nodeToRemove.value)
            {
                nodeToRemove = nodeToRemove.right;
            }
        }

        Node replacementNode = null;
        if (nodeToRemove.right != null)
        { //We have a right node
            replacementNode = nodeToRemove.right;
            if (replacementNode.left == null)
            { //We don't have a left node
                replacementNode.left = nodeToRemove.left;
            }
            else
            { //We have a have a left node, lets find the leftmost
                Node replacementParentNode = nodeToRemove;
                while (replacementNode.left != null)
                {
                    replacementParentNode = replacementNode;
                    replacementNode = replacementNode.left;
                }
                replacementParentNode.left = null;
                replacementNode.left = nodeToRemove.left;
                replacementNode.right = nodeToRemove.right;
            }
        }
        else if (nodeToRemove.left != null)
        {//We only have a left node
            replacementNode = nodeToRemove.left;
        }

        if (parentNode == null)
        {
            root = replacementNode;
        }
        else if (parentNode.left == nodeToRemove)
        { //We are a left child
            parentNode.left = replacementNode;
        }
        else
        { //We are a right child
            parentNode.right = replacementNode;
        }
    }


    int COUNT = 5;
    public void printTree(Node node)
    {
        print2DUtil(root, 0);
    }

    private void print2DUtil(Node root, int space)
    {
        // Base case  
        if (root == null)
            return;

        // Increase distance between levels  
        space += COUNT;

        // Process right child first  
        print2DUtil(root.right, space);

        // Print current node after space  
        // count  
        Console.Write("\n");
        for (int i = COUNT; i < space; i++)
        {
            Console.Write(" ");
        }
        Console.Write(root.value + "\n");

        // Process left child  
        print2DUtil(root.left, space);
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

        tree.printTree(tree.root);
    }
}