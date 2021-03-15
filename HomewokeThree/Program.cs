using System;
namespace Homework_week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                MyInterface m = MyInterface.CreatARandomGraph();
                Console.WriteLine("创建了一个" + m.ToString() + "对象，" + m.Show() + ",它的面积是：" + m.Calculate());

                sum += m.Calculate();
            }
            Console.WriteLine("这10个图形的面积总和是" + sum);
        }
    }



    //接口
    interface MyInterface
    {
        abstract public double Calculate();
        public static MyInterface CreatARandomGraph()//随机生成一个图形
        {
            int k = new Random().Next(3);
            MyInterface mi;
            switch (k)
            {
                case 0:
                    mi = new Rectangle();
                    break;
                case 1:
                    mi = new Square();
                    break;
                case 2:
                    mi = new Triangle();
                    break;
                default:
                    mi = null;
                    break;
            }
            return mi;
        }
        abstract public string Show();

    }


    class Rectangle : MyInterface//长方形
    {
        private double length;
        private double width;
        public Rectangle(double longth, double width)
        {
            this.length = longth;
            this.width = width;
        }
        public Rectangle()//重写构造函数，使其参数随机
        {
            this.length = new Random().NextDouble() * 100;
            this.width = new Random().NextDouble() * 100;
        }

        public double Calculate()
        {
            //throw new NotImplementedException();
            return this.length * this.width;
        }

        public string Show()
        {
            return "长为" + this.length + ",宽为" + this.width;
        }
    }
    class Square : MyInterface//正方形
    {
        private double sideLength;
        public Square(double length)
        {
            this.sideLength = length;
        }
        public Square()//重写构造函数，使其参数随机
        {
            this.sideLength = new Random().NextDouble() * 100;
        }
        public double Calculate()
        {
            //throw new NotImplementedException();
            return this.sideLength * this.sideLength;
        }

        public string Show()
        {
            return "边长是" + this.sideLength;
        }
    }
    class Triangle : MyInterface//三角形
    {
        double side_1;
        double side_2;
        double side_3;
        double hight_1;
        public Triangle(double side, double hight)
        {
            this.side_1 = side;
            this.hight_1 = hight;
        }
        public Triangle(double side_1, double side_2, double side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }
        public bool isReasonable()//判断三角形是否合法
        {
            if (side_1 + side_2 > side_3
                && side_1 + side_3 > side_2
                && side_3 + side_2 > side_1)
                return true;
            else
            {
                //Console.WriteLine("无法构成三角形");
                return false;
            }
        }
        public Triangle()//重写构造函数，使其参数随机
        {
            do
            {
                this.side_1 = new Random().NextDouble() * 100;
                this.side_2 = new Random().NextDouble() * 100;
                this.side_3 = new Random().NextDouble() * 100;
            } while (!isReasonable());
        }
        public double Calculate_1()
        {
            if (this.isReasonable())
            {
                return this.side_1 * this.hight_1 / 2;
            }
            else
            {
                return 0;
            }
        }
        public double Calculate()
        {
            if (this.isReasonable())
            {
                double p = (side_1 + side_2 + side_3) / 2;
                return Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
            }
            else
            {
                return 0;
            }
        }
        public string Show()
        {
            return "三边分别是" + this.side_1 + "," + this.side_2 + "," + this.side_3;
        }
    }
}
