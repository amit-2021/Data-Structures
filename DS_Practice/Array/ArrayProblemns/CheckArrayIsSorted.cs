namespace DS_Practice 
{
    public class CheckArrayIsSorted 
    {
/*
    #LeetCode
    1752. Check if Array Is Sorted and Rotated.
    Given an array nums, return true if the array was originally sorted in non-decreasing order, 
    then rotated some number of positions (including zero). Otherwise, return false.
    There may be duplicates in the original array.
    Note: An array A rotated by x positions results in an array B of the same length such that A[i] == B[(i+x) % A.length], where % is the modulo operation.
*/
        public static bool IsArrayIsSorted (int[] arr) 
        {
            bool isArraySorted = false;

            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = i + 1; j  < arr.Length; j++) 
                {
                    if (arr[j] > arr[i]) 
                    {
                        isArraySorted = true;
                        break;
                    }
                }
            }
            if (isArraySorted) 
            {

            }

            return true;
        }
    }
}