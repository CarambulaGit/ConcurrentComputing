using System;
using System.Threading;
using System.Threading.Tasks;


namespace Test {
    class Program {
        static int x = 0;
        private static object locker = new object();

        static void Main(string[] args) {
            // for (var i = 0; i < 5; i++) {
            // var myThread = new Thread(Count) {Name = "Поток " + i};
            // myThread.Start();
            // }
            var sds = new Task(Count);
            sds.Start();
            Task.Run(Count);
            Console.ReadLine();
        }

        private static void Count() {
            lock (locker) {
                Console.WriteLine($"{Thread.CurrentThread.Name}");
                x = 1;
                for (var i = 1; i < 100; i++) {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    var sad = Math.Sin(Math.Pow(x, 3));
                    Thread.Sleep(100);
                }
            }
        }
    }
}