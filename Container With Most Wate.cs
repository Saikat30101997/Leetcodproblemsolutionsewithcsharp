using System;
using System.Collections.Generic;

namespace Leetcode {
    public class Program
    {
        public int MaxArea(int[] height) {
        int mx=0;
        int area=0;
        int i=0;
        int j=height.Length-1;
        while(i<j)
        {
            
            int a=height[i];
            int b=height[j];
            int p=(j-i)*Math.Min(a,b);
            mx=Math.Max(mx,p);
            if(a<b)i++;
            else j--;
        }
        
        return mx;
    }
            public static void Main(string[] args)
        {

            
       }
    }

}