using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammig
{
    class Program
    {

        static void Main(string[] args)
        {
            //TwistedThreads.Start();
            //Console.ReadLine();

            //SleepingThreads.Start();
            //Console.ReadLine();

            //ParameterizedThread.Start();
            //Console.ReadLine();

            LockingThreads.Start();
            Console.ReadLine();
        }
    }
}
