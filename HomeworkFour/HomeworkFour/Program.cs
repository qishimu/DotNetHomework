using System;

namespace HomeworkFour
{
    class Program
    {
        public delegate int Action(GenericList<int> List);
        static void Main(string[] args)
        {
           

            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 12; x++)
            {
                intlist.Add(x);
            }
            Action d = (GenericList<int> List) =>
            {
                int []  array=new int[10] ;
                for (Node<int> node = intlist.Head ; node != null; node = node.Next)
                {
                    int i = 0;
                    array[i] = node.Data;
                    Console.WriteLine(node.Data);
                    i++;
                }
                int min = array[0];
                int max =array[0];
                for(int i = 0; i < array.Length; i++)
                {
                    if(min > array[i])
                     min = array[i];
                    if(max < array[i])
                    max = array[i];
                }
                Console.WriteLine(min);
                Console.WriteLine(max);
                Console.WriteLine(max+min);
                return 0;
            };
            d(intlist);
            GenericList<string> strList = new GenericList<string>();
            for(int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for(Node<string>node=strList.Head; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
        }
        
    }
}
//链表节点
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }
    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
//head头 tail尾
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;
    public GenericList()
    {
        tail = head = null;
    }
    public Node<T> Head
    {
        get => head;
    }
    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }
    }



  
