using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Linked_List
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/603/
    /// </summary>
    class RemoveNthNodeFromEndOfList : IQuestion
    {
        void IQuestion.Answer()
        {
            
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            //Initializes first and second nodes
            //Algorithm is looking for second node position until the end of list (first.next is null)
            ListNode first = dummy;
            ListNode second = dummy;
            
            // Advances first pointer so that the gap between first and second is n nodes apart
            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }
            
            // Move first to the end, maintaining the gap
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;

            //returns first node
            return dummy.next;
        }

    }

       public partial class  ListNode
    {
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
  }
}
