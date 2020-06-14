using System;

public class MergeSort			
{
	/***********************Algorithm*************************:
	 *  1. Divide the given array in to sub-arrays to single digit i.e cannot divide anymore
	 *       
	 *  
	 *  
	 *  2. Merge them from the single digit pair to multi value pairs i.e (2),(3) or (3,4,4,5,5,66) (4,5,6,7,8,9)
	 *    
	 *
	 *
	 **********************************************************/

	public void Sort(int[] arr, int start, int end)
	{

		if (start < end)
		{
			int mid = (start + end) / 2;

			Sort(arr, start, mid);
			Sort(arr, mid+1, end);
			Merge(arr, start, mid, end);
		}
	}

    private void Merge(int[] arr, int start, int mid, int end)
    {
		int i, j, k;
		i = start;
		j = mid + 1;
		k = 0;
		int[] temparray = new int[end-start+1];

        while (i<=mid && j<=end)
        {
			if (arr[i] < arr[j])
			{
				temparray[k] = arr[i];
				i++;
				k++;
			}
			else
			{
				temparray[k] = arr[j];
				j++;
				k++;
			}
		}


        while (i<=mid)
        {
			temparray[k] = arr[i];
			i++;
			k++;
		}

		while (j <= end)
		{
			temparray[k] = arr[j];
			j++;
			k++;
		}

		j= start;
        for ( i = 0; i < end-start+1; i++)
        {
			arr[j] = temparray[i];
			j++;
        }
	}
}
