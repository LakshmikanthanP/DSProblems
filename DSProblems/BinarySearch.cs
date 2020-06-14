using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblems
{
    public class BinarySearch
    {
        public bool BinSearch(int searchElement, int[] inputarr,int start, int end)
        {
            if (start<=end)
            {                
                int mid = (start + end) / 2;

                if (inputarr[mid] == searchElement)
                {
                    return true;
                }
                else if (searchElement > inputarr[mid])
                    return BinSearch(searchElement, inputarr, mid + 1, end);
                else
                    return BinSearch(searchElement, inputarr, start, mid - 1);
            }
            return false;
        }
    }
}
