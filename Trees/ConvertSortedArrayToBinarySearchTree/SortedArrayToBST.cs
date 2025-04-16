using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.ConvertSortedArrayToBinarySearchTree
{
    public class SortedArrayToBST
    {
        public TreeNode SortedArrayToBSTMethod(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        private TreeNode Helper(int[] nums, int left, int right)
        {
            if (left > right) return null;

            int mid = left + (right - left) / 2;  // Avoid overflow
            TreeNode node = new TreeNode(nums[mid]);

            node.left = Helper(nums, left, mid - 1);  // Left subarray
            node.right = Helper(nums, mid + 1, right); // Right subarray

            return node;
        }

        // Optional: Method to print the tree in-order (for checking)
        public void InOrder(TreeNode root)
        {
            if (root == null) return;
            InOrder(root.left);
            Console.Write(root.val + " ");
            InOrder(root.right);
        }
    }
}
