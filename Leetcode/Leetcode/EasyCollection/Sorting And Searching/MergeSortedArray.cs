using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Sorting_And_Searching
{
    class MergeSortedArray : IQuestion
    {
        public void Answer()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6};
            Merge(nums1, 3, nums2, 3);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }

            while (n > 0)
            {
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }
        }
    }
}
