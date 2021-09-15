using System;
using System.Threading;

/*
Didenko Vladyslav, Lab3
F1  1.12   A = B + C + D * (MD * ME)
F2  2.24   MG = Sort(MF - MH * MK) 
F3  3.21   S = Sort(O * MO) * (MS * MT) 
*/

namespace Lab3 {
    class Lab3 {
        public static object Locker = new object();
        public const int N = 2;

        static void Main(string[] args) {
            var mainThread = new Thread(new Lab3().Run);
            mainThread.Start();
            mainThread.Priority = ThreadPriority.Normal;
        }

        public void Run() {
            lock (new Lab3()) {
                Console.WriteLine("Lab 3 start\n");
                var thread1 = new Thread(new Function1().Run);
                var thread2 = new Thread(new Function2().Run);
                var thread3 = new Thread(new Function3().Run);

                thread1.Priority = ThreadPriority.Lowest;
                thread2.Priority = ThreadPriority.Highest;
                thread3.Priority = ThreadPriority.Normal;


                thread1.Start();
                //thread1.Join();

                thread2.Start();
                //thread2.Join();

                thread3.Start();
                //thread3.Join();

                Thread.Sleep(100);
                Console.WriteLine("Lab 3 end \n");
                // Console.Write("Press any key to end the program...");
                Console.ReadKey();
            }
        }
    }
}