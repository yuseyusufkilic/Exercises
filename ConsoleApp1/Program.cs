using System;

namespace Remove.nth.LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var head= new ListNode() { 
                next= new ListNode() { next=null,val=2},
                val=1 };
            int n = 2;

            var leftPointer=head;
            var rightPoitner=head;

            while (n>0 && rightPoitner!=null)
            {
                rightPoitner=rightPoitner.next;
                n -= 1;
            }
            while (rightPoitner!=null && rightPoitner.next !=null)
            {
                leftPointer= leftPointer.next;
                rightPoitner=rightPoitner.next;
            }
            if (leftPointer==head && rightPoitner==null)
            {
                //return head.next;

            }

            leftPointer.next = leftPointer.next.next;
           // return head;


        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
