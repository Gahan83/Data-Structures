////////////////////////////////////////////DeleteNode:

// Create the linked list: 4 -> 5 -> 1 -> 9
//using Linked_List;
//using Linked_List.DeleteNode;

//ListNode node4 = new ListNode(4);
//ListNode node5 = new ListNode(5);
//ListNode node1 = new ListNode(1);
//ListNode node9 = new ListNode(9);

//node4.next = node5;
//node5.next = node1;
//node1.next = node9;

//DeleteNode solution = new DeleteNode();

//Console.WriteLine("Original List:");
//solution.PrintList(node4); // Output: 4 5 1 9

//// Delete node with value 5
//solution.DeleteNodeMethod(node5);

//Console.WriteLine("After Deleting Node with Value 5:");
//solution.PrintList(node4); // Output: 4 1 9


////////////////////////////////////////////Remove Nth Node From End of List:
//using Linked_List;
//using Linked_List.RemoveNthFromEnd;

//RemoveNthFromEnd solution = new RemoveNthFromEnd();

//// Example 1: head = [1,2,3,4,5], n = 2
//ListNode node1 = new ListNode(1);
//ListNode node2 = new ListNode(2);
//ListNode node3 = new ListNode(3);
//ListNode node4 = new ListNode(4);
//ListNode node5 = new ListNode(5);
//node1.next = node2;
//node2.next = node3;
//node3.next = node4;
//node4.next = node5;
//ListNode result1 = solution.RemoveNthFromEndMethod(node1, 2);
//Console.Write("Output 1: ");
//solution.PrintList(result1); // Expected: 1 2 3 5

//// Example 2: head = [1], n = 1
//ListNode node6 = new ListNode(1);
//ListNode result2 = solution.RemoveNthFromEndMethod(node6, 1);
//Console.Write("Output 2: ");
//solution.PrintList(result2); // Expected: (empty)

//// Example 3: head = [1,2], n = 1
//ListNode node7 = new ListNode(1);
//ListNode node8 = new ListNode(2);
//node7.next = node8;
//ListNode result3 = solution.RemoveNthFromEndMethod(node7, 1);
//Console.Write("Output 3: ");
//solution.PrintList(result3); // Expected: 1

////////////////////////////////////////////////ReverseList:
//using Linked_List;
//using Linked_List.ReverseList;

//ReverseList solution = new ReverseList();

//// Input: [1, 2, 3, 4, 5]
//ListNode node1 = new ListNode(1);
//ListNode node2 = new ListNode(2);
//ListNode node3 = new ListNode(3);
//ListNode node4 = new ListNode(4);
//ListNode node5 = new ListNode(5);

//node1.next = node2;
//node2.next = node3;
//node3.next = node4;
//node4.next = node5;

//Console.Write("Original List: ");
//solution.PrintList(node1);

//ListNode reversedHead = solution.ReverseListMethod(node1);

//Console.Write("Reversed List: ");
//solution.PrintList(reversedHead); // Output: 5 4 3 2 1

////////////////////////////////////////////////MergedTwoSortedList:
//using Linked_List;
//using Linked_List.MergedTwoSortedList;

//MergedTwoSortedList solution = new MergedTwoSortedList();

//// Create list1: 1 -> 2 -> 4
//ListNode l1 = new ListNode(1);
//l1.next = new ListNode(2);
//l1.next.next = new ListNode(4);

//// Create list2: 1 -> 3 -> 4
//ListNode l2 = new ListNode(1);
//l2.next = new ListNode(3);
//l2.next.next = new ListNode(4);

//// Merge the lists
//ListNode merged = solution.MergeTwoLists(l1, l2);

//// Print merged list: Output should be 1 1 2 3 4 4
//Console.Write("Merged List: ");
//solution.PrintList(merged);

////////////////////////////////////////////////PalindromeLinkedList:
//using Linked_List;
//using Linked_List.PalindromeLinkedList;

//PalindromeLinkedList solution = new PalindromeLinkedList();

//// Test case 1: Palindrome [1, 2, 2, 1]
//ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
//Console.WriteLine("Is Palindrome: " + solution.IsPalindrome(head1)); // true

//// Test case 2: Not a Palindrome [1, 2]
//ListNode head2 = new ListNode(1, new ListNode(2));
//Console.WriteLine("Is Palindrome: " + solution.IsPalindrome(head2));

////////////////////////////////////////////////LinkedListCycle:

// Create nodes manually for testing
using Linked_List;
using Linked_List.LinkedListCycle;

ListNode node1 = new ListNode(3);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(0);
ListNode node4 = new ListNode(-4);

// Connect the nodes
node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node2; // Create a cycle (tail connects to node2)

LinkedListCycle solution = new LinkedListCycle();
Console.WriteLine("Has Cycle: " + solution.HasCycle(node1)); // Output: true

// Test with no cycle
ListNode a = new ListNode(1);
Console.WriteLine("Has Cycle: " + solution.HasCycle(a)); // Output: false


