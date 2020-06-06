using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection
{
    class ReturnDuplicatesFromSortedArray : IQuestion
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        public void Answer()
        {
            Console.WriteLine($"Array length is {RemoveDuplicates(nums)}");
        }

        public int RemoveDuplicates(int[] nums)
        {

        }
    }
}
