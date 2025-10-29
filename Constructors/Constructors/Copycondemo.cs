using System;

namespace Constructors
{
    class Copycondemo
    {
        int i;

        public Copycondemo(int i)
        {
            this.i = i;
        }
        public Copycondemo(Copycondemo obj)
        {
            i = obj.i;
           
        }
        public  void Display()
        {
            Console.WriteLine(i);
        }
        public static void Main(string[] args)
        {
            Copycondemo cd1 = new Copycondemo(10);
            cd1.Display();
            Copycondemo cd2 = new Copycondemo(cd1);
            cd2.Display();
        }
    }
}
