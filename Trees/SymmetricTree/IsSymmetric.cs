using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.SymmetricTree
{
    public class IsSymmetric
    {
        public bool IsSymmetricMethod(TreeNode root)
        {
            if (root == null) return true;
            return IsMirror(root.left, root.right);
        }

        // Helper function to check if two trees are mirrors
        private bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            // Both nodes must have the same value
            // And their subtrees must mirror each other
            return (t1.val == t2.val)
                && IsMirror(t1.left, t2.right)
                && IsMirror(t1.right, t2.left);
        }

    }
}
