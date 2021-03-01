using System;

namespace homFirst_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string w;
            string op;
            int result;
            System.Console.WriteLine("Please input the first number:");
            s = System.Console.ReadLine();
            int n = Convert.ToInt32(s);
            System.Console.WriteLine("Please input the second number:");
            w = System.Console.ReadLine();
            int m = Convert.ToInt32(w);
            System.Console.WriteLine("operator");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    result = n + m;
                    Console.WriteLine(result);
                    System.Console.WriteLine(result);
                    break;
                case "-":
                    result = n - m;
                    System.Console.WriteLine(result);
                    break;
                case "*":
                    result = n * m;
                    System.Console.WriteLine(result);
                    break;
                case "/":
                    result = n / m;
                    System.Console.WriteLine(result);
                    break;
                case "%":
                    result = n % m;
                    break;
            }



        }
    }
