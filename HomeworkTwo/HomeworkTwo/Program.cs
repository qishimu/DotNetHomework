using System;

namespace HomeworkTwo
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("请输入一个正整数");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            IsPrime i = new IsPrime();
            i.Judge(n);
            }
        }
    }

public class IsPrime
{
    public int Judge(int n)
    {
        for(int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n = n / i;
            }
        }
        return 0;
    }
}