using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammig
{
    class ParameterizedThread
    {
        internal static void Start()
        {
            Thread T = new Thread( () => ParameterizedThread.Print(1000, 5000));
            T.Start();
        }

        internal static void Print(int startFrom, int endTo)
        {
            for (int i = startFrom; i < endTo; i++)
            {
                Console.Write(i);
                Thread.Sleep(500);
            }

        }

    }
}
