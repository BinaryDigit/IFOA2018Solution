using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammig
{

    class LockingThreads
    {
        public static int amount = 100;

        public class Balance
        {
            Object LockObject = new Object();
            public string Name { get; set; }

            public void Withdraw(int sum)
            {
                lock (LockObject)
                {
                    if (amount >= sum)
                    {
                        amount -= sum;
                        Console.WriteLine("Balance {0} : {1} Residual Amount ({1} - {2})", this.Name, amount, sum);
                    }
                    else
                    {
                        Console.WriteLine("Balance{0} : Amount {1} < {2}", this.Name, amount, sum);
                    }

                }
            }

            public void Do()
            {
                for (int i = 0; i < 10; i++)
                {
                    Withdraw(2);
                }
            }
        }

            internal static void Start()
            {
                Balance B1 = new Balance() { Name = "Francesco" };
                Balance B2 = new Balance() { Name = "Michele" };
                Balance B3 = new Balance() { Name = "Giovanni" };

                Console.WriteLine(amount);
                for( int i = 0; i < 10; i++)
                {
                    new Thread(() => B1.Do()).Start();
                }
            }


        }
    }
