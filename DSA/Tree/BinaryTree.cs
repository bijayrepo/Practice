using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
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

        // Preorder DFS: Root -> Left -> Right
        public void Preorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            Preorder(node.Left);
            Preorder(node.Right);
        }

        // Inorder DFS: Left -> Root -> Right
        public void Inorder(Node node)
        {
            if (node == null)
                return;

            Inorder(node.Left);
            Console.Write(node.Data + " ");
            Inorder(node.Right);
        }

        // Postorder DFS: Left -> Right -> Root
        public void Postorder(Node node)
        {
            if (node == null)
                return;

            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write(node.Data + " ");
        }

        static void ChildMain()
        {
            BinaryTree tree = new BinaryTree();

            // Construct the tree
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            Console.Write("Preorder:  ");
            tree.Preorder(tree.Root);
            Console.WriteLine();

            Console.Write("Inorder:   ");
            tree.Inorder(tree.Root);
            Console.WriteLine();

            Console.Write("Postorder: ");
            tree.Postorder(tree.Root);
            Console.WriteLine();
        }
    }

}
