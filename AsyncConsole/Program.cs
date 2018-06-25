using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ClassLibrary;

namespace AsyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Prime.PAsync(250000);
            Prime.PAsync(400000);

            Console.ReadKey();
            
            
        }
    }
}
