using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammig
{
    public class TwistedThreads
    {
        public static void Start()
        {
            Thread T = new Thread(TwistedThreads.Print0);

            Thread T2 = new Thread(TwistedThreads.Print1);

            T.Start();
            T2.Start();
        }

        public static void Print0()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("0");
        }

        public static void Print1()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("1");
        }
    }
}
