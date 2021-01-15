using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection
{
    public static class LeetcodeHelper
    {
        public static void PrintOutArray(int [] nums)
        {
            string arrayContent = string.Empty;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    arrayContent = nums[i].ToString();
                }
                arrayContent += ", " + nums[i].ToString();
            }
            Console.WriteLine($"[{arrayContent}]");
        }
    }
}
