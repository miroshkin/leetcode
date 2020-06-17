using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Linked_List
{
    class DeleteNodeInALinkedList : IQuestion
    {
        void IQuestion.Answer()
        {
            var listNode9 = new ListNode(9);

            var listNode1 = new ListNode(1);
            listNode1.next = listNode9;

            var listNode5 = new ListNode(5);
            listNode5.next = listNode1;

            var listNode4 = new ListNode(4);
            listNode4.next = listNode5;

            DeleteNode(listNode1);
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }


    }


    public partial class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
