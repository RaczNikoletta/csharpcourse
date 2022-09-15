using System;

namespace countObjects
{
    class Program
    {
        static int Counter = 0;

        public Program()
        {
            Counter++;
            Console.WriteLine("Number of objects:: {0}", Counter);

        }

        ~Program()
        {
            Counter--;
            Console.WriteLine("Number of objects:: {0}", Counter);
        }
        static void Main(string[] args)
        {
           while(true)
            {
                Program temp = new Program();
            }
        }
    }
}
