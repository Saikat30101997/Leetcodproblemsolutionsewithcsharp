using System;
using System.Collections.Generic;

namespace Leetcode {
    public class Program
    {
        private string commonprefix(string s1, string s2)
        {
            int L1 = s1.Length;
            int L2 = s2.Length;
            string s3 = "";
            for (int i = 0, j = 0; i < L1 && j < L2; i++, j++)
            {
                if (s1[i] != s2[j]) break;
                s3 += s1[i];

            }
            return s3;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            
            int L = strs.GetLength(0);
            if (L == 0) return "";
            string pre = strs[0];
            for (int i = 1; i < L; i++)
            {
                pre = commonprefix(pre, strs[i]);
            }
            return pre;
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            string[] strs = {};
            Console.WriteLine( p.LongestCommonPrefix(strs));
        
                
       }
    }

}