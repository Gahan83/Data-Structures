//////////////////////////////: Maximum Depth of Binary

// Manually build the tree: [3,9,20,null,null,15,7]
//using Trees;
//using Trees.MaximumDepthOfBinary;

//TreeNode root = new TreeNode(3);
//root.left = new TreeNode(9);
//root.right = new TreeNode(20);
//root.right.left = new TreeNode(15);
//root.right.right = new TreeNode(7);

//MaxDepth solution = new MaxDepth();
//int depth = solution.MaxDepthMethod(root);
//Console.WriteLine("Maximum Depth of Binary Tree: " + depth); // Output: 3


////////////////////////////: IsValidBST

//using Trees;
//using Trees.ValidateBinarySearchTree;

//IsValidBST solution = new IsValidBST();

//// Valid BST
//TreeNode root1 = new TreeNode(2, new TreeNode(1), new TreeNode(3));
//Console.WriteLine(solution.IsValidBSTMethod(root1)); // Output: True

//// Invalid BST
//TreeNode root2 = new TreeNode(5);
//root2.left = new TreeNode(1);
//root2.right = new TreeNode(4, new TreeNode(3), new TreeNode(6));
//Console.WriteLine(solution.IsValidBSTMethod(root2)); // Output: False

////////////////////////////: IsSymmetric
//using Trees;
//using Trees.SymmetricTree;

//IsSymmetric solution = new IsSymmetric();

//// Symmetric Tree
//TreeNode root1 = new TreeNode(1,
//                    new TreeNode(2, new TreeNode(3), new TreeNode(4)),
//                    new TreeNode(2, new TreeNode(4), new TreeNode(3)));
//Console.WriteLine(solution.IsSymmetricMethod(root1)); // Output: true

//// Not Symmetric
//TreeNode root2 = new TreeNode(1,
//                    new TreeNode(2, null, new TreeNode(3)),
//                    new TreeNode(2, null, new TreeNode(3)));
//Console.WriteLine(solution.IsSymmetricMethod(root2)); // Output: false

////////////////////////////: LevelOrder
//using Trees;
//using Trees.BinaryTreeLevelOrderTraversal;

//LevelOrder solution = new LevelOrder();

//// Tree: [3,9,20,null,null,15,7]
//TreeNode root = new TreeNode(3,
//                    new TreeNode(9),
//                    new TreeNode(20, new TreeNode(15), new TreeNode(7)));

//var levels = solution.LevelOrderMethod(root);

//foreach (var level in levels)
//{
//    Console.WriteLine("[" + string.Join(",", level) + "]");
//}

////////////////////////////: IsSymmetric
using Trees;
using Trees.ConvertSortedArrayToBinarySearchTree;

SortedArrayToBST solution = new SortedArrayToBST();

int[] nums1 = { -10, -3, 0, 5, 9 };
TreeNode bst1 = solution.SortedArrayToBSTMethod(nums1);
Console.WriteLine("InOrder of BST 1:");
solution.InOrder(bst1);  // Output should be in sorted order

Console.WriteLine();

int[] nums2 = { 1, 3 };
TreeNode bst2 = solution.SortedArrayToBSTMethod(nums2);
Console.WriteLine("InOrder of BST 2:");
solution.InOrder(bst2);  // Output should be: 1 3 or 3 1