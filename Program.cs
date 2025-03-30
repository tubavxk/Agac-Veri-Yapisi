using System;

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Preorder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        Preorder(node.Left);
        Preorder(node.Right);
    }

    public void Inorder(Node node)
    {
        if (node == null) return;

        Inorder(node.Left);             
        Console.Write(node.Data + " ");
        Inorder(node.Right); 
    }

  
    public void Postorder(Node node)
    {
        if (node == null) return;

        Postorder(node.Left); 
        Postorder(node.Right);
        Console.Write(node.Data + " ");
    }

    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Right.Left = new Node(6);
        tree.Root.Right.Right = new Node(7);


        Console.WriteLine("Preorder Traversal (Kök - Sol - Sağ): ");
        tree.Preorder(tree.Root);
        Console.WriteLine("\n");

        Console.WriteLine("Inorder Traversal (Sol - Kök - Sağ): ");
        tree.Inorder(tree.Root);
        Console.WriteLine("\n");

        Console.WriteLine("Postorder Traversal (Sol - Sağ - Kök): ");
        tree.Postorder(tree.Root);
        Console.WriteLine("\n");
    }
}
