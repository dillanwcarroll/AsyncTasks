using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using ClassLibrary;

namespace MultiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mulit Threaded
            Thread thread1 = new Thread(new ThreadStart(Threads.Thread1));
            Thread thread2 = new Thread(new ThreadStart(Threads.Thread2));
  
            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        public class Threads
        {
            public static void Thread1()
            {
                Stopwatch sw1 = new Stopwatch();
                sw1.Start();
                Console.WriteLine("Thread1 {0}", Prime.PSync(250000));
                sw1.Stop();
                Console.WriteLine(sw1.Elapsed);
            }

            public static void Thread2()
            {
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                Console.WriteLine("Thread2 {0}", Prime.PSync(400000));
                sw2.Stop();
                Console.WriteLine(sw2.Elapsed);
            }
        }
    }
}
