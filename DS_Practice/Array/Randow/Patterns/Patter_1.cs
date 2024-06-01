using DS_Practice;

public class Patter_1
{
    /*
    * * * *
    * * * *
    * * * *
    * * * *
    */
    public static void Patter1(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    /*
    *
    * *
    * * *
    * * * *
    */
    public static void Patter2(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    /*
    1
    1 2
    1 2 3
    1 2 3 4
    */
    public static void Patter3(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }

    /*
    1
    2 2
    3 3 3
    4 4 4 4
    */
    public static void Patter4(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }

    /*
    * * * *
    * * *
    * *
    *
    */
    public static void Patter5(int n)
    {
        int i = 1;
        int j = 0;
        while (i <= n)
        {
            j = n - i;
            while (j >= 0)
            {
                Console.Write("* ");
                j--;
            }
            Console.WriteLine();
            i++;
        }
        //Another Logic With For Loop
        // for (int x = 1; x <= n; x++)
        // {
        //     for (int y = n - x; y >= 0; y--)
        //     {
        //         Console.Write("* ");
        //     }
        //     Console.WriteLine();
        // }
    }

    /*
    1 2 3 4 5
    1 2 3 4
    1 2 3
    1 2
    1
    */
    public static void Patter6 (int n) 
    {
        int i,j;
        i = 0;
        while (i < n) 
        {
            j = 1;
            while (j <= n - i) 
            {
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }

    /*
        *
       ***
      *****
     *******
    *********
    */
    public static void Patter7 (int n) 
    {
        for (int i = 0; i < n; i++) 
        {
            //Space
            for (int j = 0; j <= (n - i - 1); j++) 
            {
                Console.Write(" ");
            }

            //Star
            for (int j = 0; j < (2 * i + 1); j++) 
            {
                Console.Write("*");
            }

            //Space
            for (int j = 0; j < (n - i - 1); j++) 
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
