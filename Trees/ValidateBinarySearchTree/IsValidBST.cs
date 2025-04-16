using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.ValidateBinarySearchTree
{
    public class IsValidBST
    {
        // This function checks if a tree is a valid BST
        public bool IsValidBSTMethod(TreeNode root)
        {
            return Validate(root, long.MinValue, long.MaxValue);
        }

        // Helper function with range validation
        private bool Validate(TreeNode node, long min, long max)
        {
            if (node == null) return true;

            // Check if the current node violates the min/max range
            if (node.val <= min || node.val >= max) return false;

            // Left subtree must be less than current node
            // Right subtree must be greater than current node
            return Validate(node.left, min, node.val) &&
                   Validate(node.right, node.val, max);
        }
    }
}
