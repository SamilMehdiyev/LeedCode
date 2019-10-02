﻿using System;
using System.Numerics;

using LeetCode.Problems.Easy;
using LeetCode.Problems.Medium;
using LeetCode.Problems.Hard;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            processProblem4();
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

        public static void processProblem4()
        {
            //Problem4 problem = new Problem4();
            Solution2 problem = new Solution2();
            Console.WriteLine(problem.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2, 4 }));
        }

        public static void processProblem5()
        {
            ManacharsAlgorithm problem = new ManacharsAlgorithm();
            Console.WriteLine(problem.LongestPalindrome("gphyvqruxjmwhonjjrgumxjhfyupajxbjgthzdvrdqmdouuukeaxhjumkmmhdglqrrohydrmbvtuwstgkobyzjjtdtjroqpyusfsbjlusekghtfbdctvgmqzeybn" +
"wzlhdnhwzptgkzmujfldoiejmvxnorvbiubfflygrkedyirienybosqzrkbpcfidvkkafftgzwrcitqizelhfsruwmtrgaocjcyxdkovtdennrkmxwpdsxpxuarh" +
"gusizmwakrmhdwcgvfljhzcskclgrvvbrkesojyhofwqiwhiupujmkcvlywjtmbncurxxmpdskupyvvweuhbsnanzfioirecfxvmgcpwrpmbhmkdtckhvbxnsbci" +
"fhqwjjczfokovpqyjmbywtpaqcfjowxnmtirdsfeujyogbzjnjcmqyzciwjqxxgrxblvqbutqittroqadqlsdzihngpfpjovbkpeveidjpfjktavvwurqrgqdomi" +
"ibfgqxwybcyovysydxyyymmiuwovnevzsjisdwgkcbsookbarezbhnwyqthcvzyodbcwjptvigcphawzxouixhbpezzirbhvomqhxkfdbokblqmrhhioyqubpyqh" +
"jrnwhjxsrodtblqxkhezubprqftrqcyrzwywqrgockioqdmzuqjkpmsyohtlcnesbgzqhkalwixfcgyeqdzhnnlzawrdgskurcxfbekbspupbduxqxjeczpmdvss" +
"ikbivjhinaopbabrmvscthvoqqbkgekcgyrelxkwoawpbrcbszelnxlyikbulgmlwyffurimlfxurjsbzgddxbgqpcdsuutfiivjbyqzhprdqhahpgenjkbiukur" +
"vdwapuewrbehczrtswubthodv"));
        }

        public static void processProblem6()
        {
            Problem6 problem = new Problem6();
            problem.Convert("PAYPALISHIRING", 4);
        }

        public static void processProblem7()
        {
            Problem7 problem = new Problem7();
            Console.WriteLine(problem.Reverse(120));
        }
    }
}
