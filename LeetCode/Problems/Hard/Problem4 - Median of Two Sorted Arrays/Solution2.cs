﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Hard
{
    class Solution2
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int arrayLength = nums1.Length + nums2.Length;

            int[] array = new int[arrayLength];

            int center = arrayLength / 2;

            for (int i = 0; i < nums1.Length; i++)
            {
                array[i] = nums1[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                array[i + nums1.Length] = nums2[i];
            }

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (array[i] < array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return arrayLength % 2 == 0 ? (array[center - 1] + array[center]) / 2.0 : array[center];
        }
    }
}
