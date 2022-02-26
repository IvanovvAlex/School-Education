using System;

namespace DFS
{
    class Program
    {
        public class NodeOfTree
        {
            public int key;
            public NodeOfTree left, right;

            public NodeOfTree(int item)
            {
                key = item;
                left = right = null;
            }
        }

        public class Tree
        {
            NodeOfTree root;

            Tree()
            {
                root = null;
            }

            void printPostorder(NodeOfTree node)
            {
                if (node == null)
                    return;

                printPostorder(node.left);

                printPostorder(node.right);

                Console.Write(node.key + " ");
            }

            void printInorder(NodeOfTree node)
            {
                if (node == null)
                    return;

                printInorder(node.left);

                Console.Write(node.key + " ");

                printInorder(node.right);
            }

            void printPreorder(NodeOfTree node)
            {
                if (node == null)
                    return;

                Console.Write(node.key + " ");

                printPreorder(node.left);

                printPreorder(node.right);
            }

            void printPostorder() { printPostorder(root); }
            void printInorder() { printInorder(root); }
            void printPreorder() { printPreorder(root); }

            public static void Main(String[] args)
            {
                Tree tree = new Tree();
                tree.root = new NodeOfTree(1);
                tree.root.left = new NodeOfTree(2);
                tree.root.right = new NodeOfTree(3);
                tree.root.left.left = new NodeOfTree(4);
                tree.root.left.right = new NodeOfTree(5);

                Console.WriteLine("Preorder traversal ");
                tree.printPreorder();

                Console.WriteLine("\nInorder traversal ");
                tree.printInorder();

                Console.WriteLine("\nPostorder traversal ");
                tree.printPostorder();
            }
        }
    }
}
