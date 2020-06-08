using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Strings
{
    class ReverseString : IQuestion
    {
        string _s = "asdF";
        public void Answer()
        {
            ReverseStringMethod(_s.ToCharArray());
        }

        public void ReverseStringMethod(char[] s)
        {
            char buffer;
            for (int i = 0; i < s.Length / 2; i++)
            {
                buffer = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = buffer;
            }

        }
    }
}
