using System;
using System.Collections.Generic;

namespace Leetcode {
    public class Program
    {
        public int RomanToInt(string s)
        {

            int L = s.Length;
            int sum = 0;
            int akhon = 0;
            int purber = 0;
            for (int i = L - 1; i >= 0; i--)
            {
                if (s[i] == 'M') akhon = 1000;
                else if (s[i] == 'D') akhon = 500;
                else if (s[i] == 'C') akhon = 100;
                else if (s[i] == 'L') akhon = 50;
                else if (s[i] == 'X') akhon = 10;
                else if (s[i] == 'V') akhon = 5;
                else if (s[i] == 'I') akhon = 1;
                if (i == L - 1) sum = sum + akhon;
                else if (akhon < purber) sum = sum - akhon;
                else if (akhon >= purber) sum = sum + akhon;

                purber = akhon;




            }

            return sum;


        }
            public static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine( p.RomanToInt("ID"));
       }
    }

}