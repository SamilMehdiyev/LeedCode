﻿using System;
using System.Numerics;

using LeetCode.Problems.Medium;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            processProblem3();
        }

        public static void processProblem2()
        {
            Problem2 problem = new Problem2();
            ListNode result = problem.AddTwoNumbers(BigInteger.Parse("1000000000000000000000000000001"), BigInteger.Parse("564"));
            Console.WriteLine(problem.getValue(result));
        }

        public static void processProblem3()
        {
            Problem3 problem = new Problem3();
            Console.WriteLine(problem.LengthOfLongestSubstring(" "));
        }
    }
}
