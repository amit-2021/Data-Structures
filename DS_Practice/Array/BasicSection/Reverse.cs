namespace DS_Practice 
{
    public class Reverse 
    {
        public static int[] ReverseArray(int[] arr) 
        {
            int start = 0; 
            int end = arr.Length - 1;
            int temp;

            while (start < end) 
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }
    }
}