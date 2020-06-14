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
            if (x > 2147483647 || x < -2147483648)
            {
                return 0;
            }

            int sign = x >= 0 ? 1 : -1;
            x = x * sign;

            var array = x.ToString().ToCharArray();
            Stack<int> stack = new Stack<int>();
            int multiplicator = 1;
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    var item = int.Parse(array[i].ToString()) * multiplicator;

                    stack.Push(item);
                    multiplicator *= 10;
                    if (multiplicator == 1410065408)
                    {
                        multiplicator = 0;
                    }
                }
                catch (OverflowException)
                {

                    return 0;
                }
                
            }


            try
            {
                int result = 0;

                foreach (var item in stack)
                {
                    result += item;
                }
                return result * sign;
            }
            catch (OverflowException)
            {
                return 0;
            }
            


        }
    }
}
