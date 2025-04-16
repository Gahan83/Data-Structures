using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.DeleteNode
{
    public class DeleteNode
    {
        // Function to delete the given node
        public void DeleteNodeMethod(ListNode node)
        {
            // Copy the value of the next node into the current node
            node.val = node.next.val;

            // Skip the next node by pointing to the next of next
            node.next = node.next.next;
        }

        // Helper function to print the linked list
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
