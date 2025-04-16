using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.LinkedListCycle
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            // Use two pointers: slow moves one step, fast moves two steps
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;         // Move slow pointer one step
                fast = fast.next.next;    // Move fast pointer two steps

                if (slow == fast)
                {
                    // If slow and fast meet, there is a cycle
                    return true;
                }
            }

            // If fast reaches null, then there's no cycle
            return false;
        }
    }
}
