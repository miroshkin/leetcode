using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Trees
{
    class ValidateBinarySearchTree : IQuestion
    {
          //  5
          // / \
          //1   4
          //   / \
          //  3   6
        public TreeNode GetRootNode()
        {
            TreeNode tn3 = new TreeNode(3, null, null);
            TreeNode tn6 = new TreeNode(6, null, null);
            TreeNode tn4 = new TreeNode(4, tn3, tn6);
            TreeNode tn1 = new TreeNode(1, null, null);
            TreeNode tn5 = new TreeNode(5, tn1, tn4);
            return tn5;
        }

        void IQuestion.Answer()
        {
            var root = GetRootNode();
            var result = IsValidBST(root);
        }

        public bool IsValidBST(TreeNode root)
        {
            return Helper(root, null, null);
        }

        public bool Helper(TreeNode node, int? lower, int? upper)
        {
            if (node == null) return true;

            int val = node.val;
            if (lower != null && val <= lower) return false;
            if (upper != null && val >= upper) return false;

            if (!Helper(node.right, val, upper)) return false;
            if (!Helper(node.left, lower, val)) return false;
            return true;
        }

        



    }


}
