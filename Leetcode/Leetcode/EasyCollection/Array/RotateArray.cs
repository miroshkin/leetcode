using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Array
{
    /// <summary>
    /// <see href="https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/"/>
    /// </summary>
    class RotateArray : IQuestion
    {


        public void Answer()
        {
            int[] nums = {1, 2, 3, 4, 5};
            LeetcodeHelper.PrintOutArray(nums);
            int k = 2;

            nums = Rotate(nums, k);

        }

        private int[] Rotate(int[] nums, int k)
        {
            if (nums.Length % k == 0)
            {
                return nums;
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    return nums;
                }
            }

            return nums;
        }
    }
}
