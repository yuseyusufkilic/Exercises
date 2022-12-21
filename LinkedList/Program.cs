using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //** Singly Linked List** //

            var firstNode = new Node("10");
            var secondNode = new Node("20");
            var thirdNode = new Node("30");
            firstNode.NextNode = secondNode;
            secondNode.NextNode = thirdNode;
            //Console.WriteLine(firstNode.Value+" "+secondNode.Value+" "+thirdNode.Value);
            //Console.WriteLine(firstNode.NextNode.NextNode.Value); //ilk node'dan sonuncuya falan gidiyoruz ama saçma.

            //** Doubly Linked List **//
            var fDBN = new DoublyNode("11");
            var sDBN = new DoublyNode("22");
            var tDBN = new DoublyNode("33");
            fDBN.NextNode = sDBN;
            fDBN.PreviousNode = tDBN;
            sDBN.NextNode = tDBN;
            sDBN.PreviousNode = fDBN;
            tDBN.PreviousNode = sDBN;
            tDBN.NextNode = fDBN;

            //Console.WriteLine(fDBN.NextNode.NextNode.Value);
            //Console.WriteLine(tDBN.PreviousNode.PreviousNode.Value);



        }

    }
    class Node
    {
        public string Value { get; set; }
        public Node NextNode { get; set; }

        public Node(string value, Node nextNode=null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }
    }

    class DoublyNode
    {
        public string Value { get; set; }
        public DoublyNode NextNode { get; set; }
        public DoublyNode PreviousNode { get; set; }

        public DoublyNode(string value, DoublyNode nextNode = null, DoublyNode previousNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
            this.PreviousNode = previousNode;
        }

    }

    
}
