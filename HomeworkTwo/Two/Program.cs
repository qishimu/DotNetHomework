using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Console.WriteLine("请问您要输入一个多长的整数数组");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);  
            int[] list;
            list = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("请开始输入数组中第"+(i+1)+"个数字");
                list[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("该整数数组的最小值为" + m.GetMin(list));
            Console.WriteLine("该整数数组的最大值为" + m.GetMax(list));
            Console.WriteLine("该整数数组的合值为" + m.GetSum(list));
            Console.WriteLine("该整数数组的平均值为" + m.GetAve(list));
        }
        public class MyMath {
            public int GetMin(int[] list)
            {
                int min = int.MaxValue;
                foreach (int i in list)
                {
                    if (i < min)
                        min = i;
                }
                return min;
            }
            public int GetMax(int[] list)
            {
                int max = 0;
                foreach (int i in list)
                {
                    if (i > max)
                        max = i;
                }
                return max;
            }
            public int GetSum(int[] list) {
                int sum = 0;
                foreach (int i in list)
                {
                    sum += i;
                }
                return sum;
            }
            public float GetAve(int[] list)
            {
                float sum = 0;
                float Ave;
                foreach (int i in list)
                {
                    sum += i;
                }
                Ave = sum / list.Length;//两个int相除结果为int
                return Ave;
            }
        }
    }
}
