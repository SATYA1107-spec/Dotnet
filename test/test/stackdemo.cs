using System;
using System.Collections;
using System.Collections.Generic;

class stackdemo
{
    public static void Main(string[] args)
    {
        Stack<int> st = new Stack<int>();
        st.Push(1);
        st.Push(22);
        st.Push(43);
        st.Push(4);
        st.Push(5);
        st.Push(6);
       
        foreach(int i in st)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");
        Queuedemo queuedemo = new Queuedemo();
        queuedemo.quuwdem();

    }
}
class Queuedemo
{
     public void quuwdem()
    {
        Queue<string> q = new Queue<string>();
        Queue qa = new Queue();
        qa.Enqueue(1);
        qa.Enqueue(22);
        q.Enqueue("satya");
        q.Enqueue("geethika");

        qa.Dequeue();
        qa.Dequeue();

        foreach (int i in qa)
        {
            Console.WriteLine(i);
        }
        foreach ( string i in q)
        {
            Console.WriteLine(i);
        }
        

    }
}
