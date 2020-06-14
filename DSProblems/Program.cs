using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Maximum_SubArray.Find_Max_Sum(input);
            //Maximum_SubArrayOpti.Find_Max_Sum(input);

            //int[] JPinput = new int[] { 0, 3, 1, 1, 4 };
            //JumpGame JG = new JumpGame();
            //JG.CanJump(JPinput); 

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nums1 = { -1, -100, 3, 99 };
            //int[] nums2 = { 1,2 };
            ////int[] nums = { -1 };
            //int k = 3;

            //RotateArray RA = new RotateArray();
            //RA.Rotate3(nums2, 2);
            //int[] input = new int[] { 0, 1, 2, 3, 4, 5 };

            //RA.solution("abccbd", input);


            int[] input = new int[] { 6,5,3,1,8,7,2,4 };

            //MergeSort msort = new MergeSort();
            //msort.Sort(input, 0, input.Length - 1);

            QuickSort qsort = new QuickSort();
            qsort.Sort(input, 0, input.Length - 1);
           
            BinarySearch BS = new BinarySearch();
            var res =BS.BinSearch(5,input,0,7);

            //string s = "Inndia";

            //SorterCharactersFrequency sF = new SorterCharactersFrequency();

            //sF.FrequencySort(s);

        }
    }
}
