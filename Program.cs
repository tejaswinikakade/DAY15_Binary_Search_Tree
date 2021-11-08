using System;

namespace Binary_Serch_Tree_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree<int> binaryTree = new MyBinaryTree<int>(56);

            //UC1
            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Print();




            //UC2
            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Add(22);
            binaryTree.Add(40);
            binaryTree.Add(60);
            binaryTree.Add(95);
            binaryTree.Add(11);
            binaryTree.Add(65);
            binaryTree.Add(3);
            binaryTree.Add(16);
            binaryTree.Add(63);
            binaryTree.Add(67);
            binaryTree.Print();


            //UC3
            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Add(22);
            binaryTree.Add(40);
            binaryTree.Add(60);
            binaryTree.Add(95);
            binaryTree.Add(11);
            binaryTree.Add(65);
            binaryTree.Add(3);
            binaryTree.Add(16);
            binaryTree.Add(63);
            binaryTree.Add(56);
            binaryTree.Print();

            bool result = binaryTree.Search(67, binaryTree);
            Console.WriteLine(result);


            Console.ReadKey();

        }
    }
}