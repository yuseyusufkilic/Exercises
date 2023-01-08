using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree.Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tree
            //Tree<int> newTree= new Tree<int>();

            //var returned=newTree.Insert(new Node<int>() { Value=10});
            //var returned2 = newTree.Insert(new Node<int>() { Value = 8});
            //var returned3 = newTree.Insert(new Node<int>() { Value = 102 });
            //var returned4 = newTree.Insert(new Node<int>() { Value = 105 });
            //var returned5 = newTree.Insert(new Node<int>() { Value = 106 });
            //var returned7 = newTree.Insert(new Node<int>() { Value = 1026 });
            //var returned6 = newTree.Insert(new Node<int>() { Value = 4 });

            //Console.WriteLine("-------------------");
            //Console.WriteLine(newTree.Root.Left.Value);
            //Console.WriteLine(newTree.Root.Left.Left.Value);
            //Console.WriteLine(newTree.Root.Right.Value);
            //Console.WriteLine(newTree.Root.Right.Right.Value);
            //Console.WriteLine(newTree.Root.Right.Right.Right.Value);
            //Console.WriteLine(newTree.Contains(new Node<int>() { Value = 4 }));
            //Console.WriteLine(newTree.GetMaxNode());

            #endregion

            Console.WriteLine(FactorialCalc(7));
            Console.WriteLine(ContigousSum(7));
            ReverseString(new char[] { 'h', 'e','l','l','o' }).ToList().ForEach(w => Console.WriteLine(w));

        }
        public static int FactorialCalc(int num)
        {
            if (num == 0)
            {
                return 1;

            }
            else
            {
                return num * FactorialCalc(num - 1);
            }

        }
        public static int ContigousSum(int num)
        {
            if (num==0)
            {
                return 0;

            }
            else
            {
                return num + ContigousSum((int)num -1);
            }
        }
        public static char[] ReverseString(char[] str)
        {
            char[] newArr = new char[str.Length];
            var border = str.Count()-1;
            for (int i = 0; i < str.Count(); i++)
            {
                newArr[i] = str[border - i];

            }
            str = newArr;
            return str;
           
            
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

    }
    public class Tree<T>
    {
        public Node<T> Root { get; set; }      
        public bool Insert(Node<T> node)
        {
            bool isAdded=false;
            if (this.Root==null)
            {
                this.Root = node;
                isAdded=true;
                return isAdded;

            }

            var tempNode=this.Root;
            while (!isAdded)
            {
                if (Convert.ToInt32(node.Value) == Convert.ToInt32(tempNode.Value))
                {
                    isAdded = false;
                    return isAdded;

                }
                if (Convert.ToInt32(node.Value) < Convert.ToInt32(tempNode.Value))
                {
                    if (tempNode.Left==null)
                    {
                        tempNode.Left = node;
                        isAdded= true;
                        return isAdded;

                    }
                    else
                    {
                        tempNode = tempNode.Left;
                    }


                }
                else
                {
                    if (tempNode.Right==null)
                    {
                        tempNode.Right = node;
                        isAdded= true;
                        return isAdded;

                    }
                    else
                    {
                        tempNode = tempNode.Right;
                    }
                }


            }
            return isAdded;
        }

        public bool Contains(Node<T> node)
        {
            var tempNode = this.Root;
            while (tempNode !=null)
            {
                if (Convert.ToInt32(node.Value) < Convert.ToInt32(tempNode.Value))
                {
                    tempNode = tempNode.Left;

                }
                else if (Convert.ToInt32(node.Value) > Convert.ToInt32(tempNode.Value))
                {
                    tempNode = tempNode.Right;

                }
                else
                {
                    return true;
                }              
            }
            return false;
        }
        public T GetMaxNode()
        {
            var tempNode = this.Root;
            while (tempNode.Right !=null)
            {
                tempNode= tempNode.Right;

            }
            return tempNode.Value;
        }
       
    }
}
