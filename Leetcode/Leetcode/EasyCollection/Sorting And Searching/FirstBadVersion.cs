using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.EasyCollection.Sorting_And_Searching
{
    class FirstBadVersionQuestion : IQuestion
    {
        List<AppVersion> _appVersions;
        public void Answer()
        {
            InitializeCollection();
            var firstBadVersion = FirstBadVersion(5);
        }

        private void InitializeCollection()
        {
            _appVersions = new List<AppVersion>();

            var av1 = new AppVersion() { Number = 1, IsBad = false };
            var av2 = new AppVersion() { Number = 2, IsBad = false };
            var av3 = new AppVersion() { Number = 3, IsBad = false };
            var av4 = new AppVersion() { Number = 4, IsBad = true };
            var av5 = new AppVersion() { Number = 5, IsBad = true };

            _appVersions.Add(av1);
            _appVersions.Add(av2);
            _appVersions.Add(av3);
            _appVersions.Add(av4);
            _appVersions.Add(av5);
        }

        /// <summary>
        /// Binary search in sorted list
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (isBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        public bool isBadVersion(int version)
        {
            return _appVersions.Find(av => av.Number == version).IsBad;
        }


    }

    class AppVersion
    {
        public int Number { get; set; }
        public bool IsBad { get; set; }
    }
}
