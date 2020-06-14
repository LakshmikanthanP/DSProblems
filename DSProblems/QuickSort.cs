using System;
using System.Runtime.InteropServices;
/***********************Algorithm*************************:
*  1.Select pivot element
*  2. Put it in correct index ( left lesser and right higher elements)     
*  3. Once pivot placed. repeat for left and right sub-array
*  
**********************************************************/
public class QuickSort
{
	public void Sort(int[] arr, int startindex, int endindex)
	{


		if (startindex < endindex)
		{
			var pivotindex = FindPivotindex(arr, startindex, endindex);

			Sort(arr, startindex, pivotindex - 1);
			Sort(arr, pivotindex + 1, endindex);
		}


	}

	public static string wheels;

	public static void Mymethod() { }

    private int FindPivotindex(int[] arr, int startindex, int endindex)
    {
		int pivotelement = arr[endindex];
		int i = 0;
		int j = endindex-1;

		while (i<=j)
        {
            if (arr[i]>pivotelement)
            {
				swap(ref arr[i], ref arr[j]);
				j--;
            }
            else
            {
				i++;
            }
        }

		swap(ref arr[i], ref arr[endindex]);

		return i;

	   void swap(ref int x, ref int y)
		{
			var temp = x;
			x = y;
			y = temp;
		}
    }
}
