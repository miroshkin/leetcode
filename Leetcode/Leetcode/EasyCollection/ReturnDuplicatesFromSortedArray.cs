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
            PrintOutArray();
        }

        private void PrintOutArray()
        {
            string arrayContent = string.Empty;
            for (int i = 0; i < nums.Length; i++)
            {
                arrayContent += ", " + nums[i].ToString();
            }
            Console.WriteLine($"[{arrayContent}]");
        }

        public int RemoveDuplicates(int[] nums)
        {
            //Checks the initial array length
            //If the array is empty function returns 0
            if (nums.Length == 0) return 0;
            
            //There is one element in array at least
            int i = 0;
            
            //Loop starts from the second array element
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
