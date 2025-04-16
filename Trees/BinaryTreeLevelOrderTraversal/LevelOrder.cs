using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTreeLevelOrderTraversal
{
    public class LevelOrder
    {
        public IList<IList<int>> LevelOrderMethod(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Number of nodes in the current level
                List<int> currentLevel = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);

                    // Enqueue children for the next level
                    if (currentNode.left != null) queue.Enqueue(currentNode.left);
                    if (currentNode.right != null) queue.Enqueue(currentNode.right);
                }

                result.Add(currentLevel);
            }

            return result;
        }
    }
}
