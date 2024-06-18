using System;

namespace DS_Practice 
{
    public static class Helper 
    {
        public static void Print<T>(T[] arr) 
        {
            foreach (T data in arr) 
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
