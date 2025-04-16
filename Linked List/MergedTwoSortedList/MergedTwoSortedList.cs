using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.MergedTwoSortedList
{
    public class MergedTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to simplify the logic
            ListNode dummy = new ListNode();
            ListNode tail = dummy; // Tail keeps track of the last node in the merged list

            // While both lists are not empty
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;  // Point tail to the smaller node
                    list1 = list1.next; // Move to next node in list1
                }
                else
                {
                    tail.next = list2;  // Point tail to the smaller node
                    list2 = list2.next; // Move to next node in list2
                }
                tail = tail.next; // Move the tail forward
            }

            // If any list is not empty, connect it to the merged list
            if (list1 != null)
                tail.next = list1;
            else
                tail.next = list2;

            return dummy.next; // dummy.next is the head of the merged list
        }

        // Helper method to print the list
        public void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}
