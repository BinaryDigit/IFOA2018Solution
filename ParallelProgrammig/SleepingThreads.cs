using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammig
{
    class SleepingThreads
    {
        
        public static void Start()
        {
            Thread T = new Thread(SleepingThreads.Print0);

            Thread T2 = new Thread(SleepingThreads.Print1);

            T.Start();
            T2.Start();
        }

        internal static void Print0()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("0");
                Thread.Sleep(2000);
            }
                
        }

        internal static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("1");
                Thread.Sleep(500);
            }
        }
    }
}
