namespace DS_Practice
{
    public static class TwoSum
    {
        public static bool isTwoSumFound(int[] arr, int target)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine("Target found...");
                        return true;
                    }
                }
            }
            Console.WriteLine("Target Not Found...");
            return false;
        }
    }
}
