using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblems
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int[] temp = new int[nums.Length];
            int j = 0;
            int p = 0;
            int n = nums.Length;

            if (n-k <0)
            {
                return;
            }

            for (int i = n - k; i < n; i++)
            {
                temp[j] = nums[i];
                j++;
            }

            p = k;
            for (int i = 0; i < n - k; i++)
            {
                temp[p] = nums[i];
                p++;
            }

            Array.Copy(temp, nums, temp.Length);


        }

        public void Rotate2(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                RotateOnetime();
            }
            //
            //var temp = nums[0];

            //nums[0] = nums[6];
            //nums[6] = nums[5];
            //nums[5] = nums[4];
            //nums[4] = nums[3];
            //nums[3] =  nums[2];
            //nums[3] =  nums[2];
            //nums[2] =  nums[1];
            //nums[1] =  temp;

            void RotateOnetime()
            {
                var temp1 = nums[0];

                nums[0] = nums[nums.Length - 1];

                for (int i = nums.Length-1; i > 1; i--)
                {                    
                     nums[i] = nums[i-1];
                }

                nums[1] = temp1;
            }
        }

        public void Rotate3(int[] nums, int k)
        {
            ReverseArray(nums, 0,nums.Length-1);
            ReverseArray(nums, 0, k-1);

            k %= nums.Length;

            ReverseArray(nums, k, nums.Length - 1);
            
        }

        private static void ReverseArray(int[] nums, int startindex, int length)
        {
            int i = startindex;
            int temp = 0;
            int j = length;
            for (i = startindex; i < j; i++)
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j--;
            }

        }

        public int solution(string S, int[] C)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int TotalCost = 0;
            char[] CharArray = S.ToCharArray();
            int start = 0;
            int nextToStart = 1;
            int end = CharArray.Length;

            while (start < end && nextToStart < end)
            {
                if (start == nextToStart)
                {
                    TotalCost += C[start];
                }
                start++;
                nextToStart++;
            }

            return TotalCost;
        }
    }
}
            