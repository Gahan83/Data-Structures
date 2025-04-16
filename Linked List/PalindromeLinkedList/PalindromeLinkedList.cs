using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.PalindromeLinkedList
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            // Step 1: Find the middle of the linked list using slow and fast pointers
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Step 2: Reverse the second half of the list
            ListNode secondHalf = ReverseList(slow);

            // Step 3: Compare both halves
            ListNode firstHalf = head;
            while (secondHalf != null)
            {
                if (firstHalf.val != secondHalf.val)
                    return false;
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return true;
        }

        // Helper method to reverse a linked list
        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode nextNode = head.next; // Store next node
                head.next = prev;              // Reverse the pointer
                prev = head;                   // Move prev forward
                head = nextNode;               // Move current forward
            }
            return prev; // New head of reversed list
        }

        // Helper to print the list (optional)
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
