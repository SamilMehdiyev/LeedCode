﻿using System;
using System.Numerics;

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
            Problems.Medium.Problem2.Solution problem = new Problems.Medium.Problem2.Solution();
            Problems.Medium.Problem2.ListNode result = problem.AddTwoNumbers(BigInteger.Parse("1000000000000000000000000000001"), BigInteger.Parse("564"));
            Console.WriteLine(problem.getValue(result));
        }

        public static void processProblem3()
        {
            Problems.Medium.Problem3.Solution problem = new Problems.Medium.Problem3.Solution();
            Console.WriteLine(problem.LengthOfLongestSubstring(" "));
        }

        public static void processProblem4()
        {
            //Problems.Hard.Problem4.Solution problem = new Problems.Hard.Problem4.Solution();
            Problems.Hard.Problem4.Solution2 problem = new Problems.Hard.Problem4.Solution2();
            Console.WriteLine(problem.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2, 4 }));
        }

        public static void processProblem5()
        {
            Problems.Medium.Problem5.ManacharsAlgorithmSolution problem = new Problems.Medium.Problem5.ManacharsAlgorithmSolution();
            Console.WriteLine(problem.LongestPalindrome("gphyvqruxjmwhonjjrgumxjhfyupajxbjgthzdvrdqmdouuukeaxhjumkmmhdglqrrohydrmbvtuwstgkoby" +
                "zjjtdtjroqpyusfsbjlusekghtfbdctvgmqzeybn" +
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
            Problems.Medium.Problem6.Solution problem = new Problems.Medium.Problem6.Solution();
            problem.Convert("PAYPALISHIRING", 4);
        }

        public static void processProblem7()
        {
            Problems.Easy.Problem7.Solution problem = new Problems.Easy.Problem7.Solution();
            Console.WriteLine(problem.Reverse(120));
        }
    }
}
