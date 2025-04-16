using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.MaximumDepthOfBinary
{
    public class MaxDepth
    {
        // This function calculates the maximum depth of the binary tree
        public int MaxDepthMethod(TreeNode root)
        {
            // Base case: If the root is null, the depth is 0
            if (root == null) return 0;

            // Recursively get the depth of left and right subtrees
            int leftDepth = MaxDepthMethod(root.left);
            int rightDepth = MaxDepthMethod(root.right);

            // Return the greater of the two depths + 1 for the current node
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
