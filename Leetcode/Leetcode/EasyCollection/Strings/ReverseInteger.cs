using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Strings
{
    class ReverseInteger : IQuestion
    {
        void IQuestion.Answer()
        {
            var result = Reverse(2147483647);
        }

        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && pop > 7)) return 0;
                if (result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 && pop < -8)) return 0;
                result = result * 10 + pop;
            }
            return result;



        }
    }
}
