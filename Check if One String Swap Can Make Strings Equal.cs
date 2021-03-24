using System;
using System.Collections.Generic;

namespace Leetcode {
    public class Program
    {
        public bool AreAlmostEqual(string s1, string s2)
        {


            int L1 = s1.Length;


            string s3 = "";
            string s4 = "";
            int cnt = 0;
            bool check = false;
            for (int i = 0; i < L1; i++)
            {
                if (s1[i] == s2[i]) continue;
                if (s1[i] != s2[i])
                {
                    cnt++;
                    s3 += s1[i];
                    s4 += s2[i];
                }
            }
            if (cnt > 2) check = false;
            else if (cnt == 0) check = true;
            else if (cnt == 2)
            {
                if (s3[0] == s4[1] && s3[1] == s4[0]) check = true;
                else check = false;
            }
            return check;
        }
        public static void Main(string[] args)
        {

            Program p = new Program();
            p.AreAlmostEqual("bank", "knab");
       }
    }

}