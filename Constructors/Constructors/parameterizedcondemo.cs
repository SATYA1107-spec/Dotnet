using System;

namespace Constructors
{
    class parameterizedcondemo
    {
        int i;

        public parameterizedcondemo(int i)
        {
            this.i = i;
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            parameterizedcondemo pd1 = new parameterizedcondemo(10);
            parameterizedcondemo pd2 = new parameterizedcondemo(20);
            parameterizedcondemo pd3 = new parameterizedcondemo(30);
        }
    }

}
