namespace Linked_List.RemoveNthFromEnd
{
    public class RemoveNthFromEnd
    {
        public ListNode RemoveNthFromEndMethod(ListNode head, int n)
        {
            // Create a dummy node to handle edge cases (like deleting head)
            ListNode dummy = new ListNode(0, head);

            // Initialize two pointers starting at dummy
            ListNode fast = dummy;
            ListNode slow = dummy;

            // Move fast pointer n+1 steps ahead
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            // Move both pointers until fast reaches the end
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            // Now, slow is just before the node to be deleted
            slow.next = slow.next.next;

            // Return the real head (after dummy)
            return dummy.next;
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
