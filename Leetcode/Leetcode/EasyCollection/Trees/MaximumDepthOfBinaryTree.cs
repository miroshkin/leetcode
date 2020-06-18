using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Trees
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/94/trees/555/
    class MaximumDepthOfBinaryTree : IQuestion
    {
          //        3
          //       / \
          //      9  20
          //        /  \
          //       15   7

        public TreeNode GetRootNode()
        {
            TreeNode tn15 = new TreeNode(15, null, null);
            TreeNode tn7 = new TreeNode(7, null, null);
            TreeNode tn20 = new TreeNode(20, tn15, tn7);
            TreeNode tn9 = new TreeNode(9, null, null);
            TreeNode tn3 = new TreeNode(3, tn9, tn20);
            return tn3;
        }

        void IQuestion.Answer()
        {
            TreeNode root = GetRootNode();
            var result = MaxDepth(root);
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            //Left subtree depth     
            var leftSubtreeDepth = MaxDepth(root.left);

            //Right subtree depth
            var rightSubtreeDepth = MaxDepth(root.right);

            //Use the max value of two
            return leftSubtreeDepth > rightSubtreeDepth ? leftSubtreeDepth + 1 : rightSubtreeDepth + 1;
        }
    }

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
                 }
  }
}
