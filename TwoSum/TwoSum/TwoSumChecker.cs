using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class TwoSumChecker
    {
        public static int[] Check(int[] nums, int target)
        {
            List<int> ar=new List<int>();
            Dictionary<int, int> dict=new Dictionary<int, int>();

            for (int x=0; x<nums.Length; x++)
            {
                int comp = target - nums[x];
                if (dict.ContainsKey(comp))
                {
                    ar.Add(dict[comp]);
                    ar.Add(x);
                }
                else {
                    dict.Add(nums[x], x);
                }
            }

            return ar.ToArray();
        }
    }
}
