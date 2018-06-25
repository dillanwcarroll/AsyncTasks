using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary
{
    public class Prime
    {
        public static long PSync(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;

                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }

        public async static void PAsync(int input)
        {
            var task = await Task.Run(() => PSync(input));
            Console.WriteLine(task);
            Console.WriteLine(DateTime.Now);

        }

        public static async Task<long> testWPFAsync(int input) //not needed I realised, because eve
        {
            var task = await Task.Run(() => PSync(input));
            return task;

        }
    }
}