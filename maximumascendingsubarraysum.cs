using System;
using System.Collections.Generic;

namespace Leetcode {
    public class Program
    {

        public int sum(int[] nums)
        {
            int L = nums.Length;
            int mx = 0, p = 0, tot = 0;
            for (int i = 0; i < L; i++)
            {
                p = nums[i];
                tot = p;
                for (int j = i + 1; j < L; j++)
                {
                    if (p < nums[j])
                    {
                       
                        tot += nums[j];
                        p = nums[j];
                        if (j == L - 1) mx = Math.Max(tot, mx);

                    }
                    else
                    {
                        mx = Math.Max(tot, mx);
                       
                        break;
                    }

                }
            }
            mx = Math.Max(tot, mx);
            return mx;
        }
       
          public static void Main(string[] args)
        {
            int[] nums = new int[] {6};
            Program p = new Program();
            int x = p.sum(nums);
            Console.WriteLine(x);
            
            
        }
    }

}