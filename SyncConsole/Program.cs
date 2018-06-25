using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ClassLibrary;

namespace SyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw1.Start();
            sw2.Start();

            var task = Prime.PSync(250000);
            Console.WriteLine(task);
            sw1.Stop();
            Console.WriteLine(sw1.Elapsed);

            var task1 = Prime.PSync(400000);
            Console.WriteLine(task1);
            sw2.Stop();
            Console.WriteLine(sw2.Elapsed);

            Console.ReadKey();
        }
    }
}
