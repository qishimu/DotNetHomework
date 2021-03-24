using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ra = new Random();
            int a = ra.Next(5);
            int b = ra.Next(10);
            Form form1 = new Form();
            form1.ClockOne.OnAlarm();
            form1.ClockOne.OnTick(a, b);
        }
    }
}
public delegate void AlarmClock(object punctual, ClockTime c);//参数的思考

public class ClockTime
{
    public int X
    {
        get;set;
    }
    public int Y
    {
        get;set;
    }
}
public class Clock
{
    public event AlarmClock Alarm;
    public event AlarmClock Tick;
    public void OnTick(int x, int y)//触发Tick的方法
    {
        ClockTime arg = new ClockTime()
        {
            X = x,
            Y = y
        };
        do
        {
                TimeSpan ts = new TimeSpan(1000);
                y++;
                Console.WriteLine("滴答" + x + ":" + y);
            } while (x <= 5 && y < 10);
        do
        {
            y = 0; x ++;
            Console.WriteLine("滴答" + x + ":" + y);
        } while (x != 5 && y == 10);
        do
        {
            y = 0; x = 0;
            Console.WriteLine("滴答" + x + ":" + y);
        } while (x == 5 && y == 10);
    }
    public void OnAlarm()//触发Alarm的方法
    {
        Console.WriteLine("请设置闹铃的时间");
        string m=Console.ReadLine();
        int x = Convert.ToInt32(m);
        string n = Console.ReadLine();
        int y = Convert.ToInt32(n);
        ClockTime arg = new ClockTime();
        do
        {
          Console.WriteLine("闹铃响了,该开始了");
        } while (x == arg.X && y ==arg. Y);
    }
}
public class Form
{
    public Clock ClockOne = new Clock();
    public Form()
    {
        ClockOne.Alarm += new AlarmClock(BeAlarm);
        ClockOne.Tick += new AlarmClock(BeTick);
        static void BeTick(object punctual, ClockTime c)
        {

        }
        static void BeAlarm(object punctual, ClockTime c)
        {

        }
    }
}


