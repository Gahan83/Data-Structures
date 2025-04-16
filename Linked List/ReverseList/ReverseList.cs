using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.ReverseList
{
    public class ReverseList
    {
        public ListNode ReverseListMethod(ListNode head)
        {
            ListNode prev = null;     // Initially, previous node is null
            ListNode current = head;  // Start with head of the list

            while (current != null)
            {
                ListNode nextTemp = current.next; // Store next node temporarily
                current.next = prev;              // Reverse the current node's pointer
                prev = current;                   // Move prev forward
                current = nextTemp;               // Move current forward
            }

            return prev; // prev is the new head after reversal
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
