using System;

namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for(int i = 2; i < array.Length; i++)
            {
                array[i] = i ;//数组的数目可能和下标并没有对齐
               // Console.WriteLine(array[i])
            }
            for (int i = 2; i < array.Length; i++)
            {
                int n;
                if (array[i] != 0)
                {
                    for (n = 2 * array[i]; n < array.Length; n = n + array[i])
                    {
                        array[n] = 0;
                       // Console.WriteLine("这是"+n);
                       //依次剔除2的二倍三倍四倍……3的二倍……
                    }
                }
                if (array [i]!= 0)
                {
                    Console.WriteLine(array[i]);
                }

            }
          
        }
    }
}
