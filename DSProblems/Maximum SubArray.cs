using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblems
{
    // Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    //https://leetcode.com/problems/maximum-subarray/
    //Input: [-2,1,-3,4,-1,2,1,-5,4],
    // Output: 6
    //Explanation: [4,-1,2,1] has the largest sum = 6.
    //

    public static class Maximum_SubArray
    {
        static int currentsum, max_so_far = 0;

        public static int  Find_Max_Sum(int[] nums)
        {
            //brute-force
            for (int i = 0; i < nums.Length; i++)
            {
                currentsum = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    currentsum += nums[j];

                    if (max_so_far < currentsum)
                    {
                        max_so_far = currentsum;
                    }
                }
            }
            return max_so_far;
        }
    }
    public static class Maximum_SubArrayOpti
    {
        static int currentsum, max_so_far = 0;
       
        public static int Find_Max_Sum(int[] nums)
        {
            //brute-force
            for (int i = 0; i < nums.Length; i++)
            {
                currentsum += nums[i];
                
                if (max_so_far < currentsum)
                {
                    max_so_far = currentsum;
                }

                if (currentsum < 0)
                {
                    currentsum = 0;
                }
                
            }

            return max_so_far;
        }
    }

}
