namespace DS_Practice 
{
    public class Recursion 
    {
        public static void PrintNtime (int n) 
        {
            if (n == 0) 
            {
                return;
            }
            PrintNtime(n -1);
            Console.WriteLine(n);
        }

        public static void Print1ToNInAscedntingOrder (int n) 
        {
            if (n == 0) 
            {
                return;
            }
            Print1ToNInAscedntingOrder(n -1);
            Console.WriteLine(n);
        }

        public static void Print1ToNInDescedntingOrder (int n) 
        {
            if (n == 0) 
            {
                return;
            }
            Console.WriteLine(n);
            Print1ToNInDescedntingOrder(n -1);
        }
    }
}