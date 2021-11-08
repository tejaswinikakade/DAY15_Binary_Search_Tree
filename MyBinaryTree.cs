using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Serch_Tree_Day15
{
    class MyBinaryTree<T> where T : IComparable<T>
    {
        public T Node { get; set; }
        public MyBinaryTree<T> leftNode { get; set; }
        public MyBinaryTree<T> rightNode { get; set; }

        public MyBinaryTree(T nodedata)
        {
            this.Node = nodedata;
            this.rightNode = null;
            this.leftNode = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Add(T item)
        {
            T currentNodeValue = this.Node;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftNode == null)
                    this.leftNode = new MyBinaryTree<T>(item);
                else
                    this.leftNode.Add(item);
                Console.WriteLine(item + "Added to left");

            }

            else
            {
                if (this.rightNode == null)
                    this.rightNode = new MyBinaryTree<T>(item);
                else
                    this.rightNode.Add(item);
                Console.WriteLine(item + "Added to right");
            }
        }

        public bool Search(T element, MyBinaryTree<T> node)
        {
            if (node == null)
                return false;

            if (node.Node.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.Node);
                result = true;
            }
            else
                Console.WriteLine("Did not found the element in BST" + " " + node.Node);

            if (element.CompareTo(node.Node) < 0)
                Search(element, node.leftNode);

            if (element.CompareTo(node.Node) < 0)
                Search(element, node.rightNode);

            return result;

        }

        public void Print()
        {
            if (this.leftNode != null)
            {
                this.leftCount++;
                this.leftNode.Print();

            }

            Console.WriteLine(this.Node.ToString());

            if (this.rightNode != null)
            {
                this.rightCount++;
                this.rightNode.Print();
            }
        }
    }
}