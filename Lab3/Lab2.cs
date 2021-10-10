using System;
using System.Threading;

/*
 * Parallel programming.
 * Labwork 2. C#.
 *
 * F1  1.12  A = B + C + D * (MD * ME)
 * F2  2.24  MG = sort(MF - MH * MK)
 * F3  3.21  S = sort(O * MO) * (MS * MT)
 * 
 * Didenko Vladyslav
 * IO-91
 * 16.09.2021
 */

namespace Lab2 {
    class Lab2 {
        public const int N = 2;

        public static void Main(string[] args) {
            Console.WriteLine("Lab 2 start\n");
            // var T1 = new Thread(new Function1(Function.FillType.Random).Run);
            // var T2 = new Thread(new Function2(Function.FillType.Random).Run);
            // var T3 = new Thread(new Function3(Function.FillType.Random).Run);

            var T1 = new Thread(new Function1(1).Run);
            var T2 = new Thread(new Function2(1).Run);
            var T3 = new Thread(new Function3(1).Run);

            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T3.Priority = ThreadPriority.Normal;


            T1.Start();
            //T1.Join();

            T2.Start();
            //T2.Join();

            T3.Start();
            //T3.Join();

            // Thread.Sleep(100);
            Console.WriteLine("Lab 2 finished \n");
        }
    }

    public static class DefaultOperations {
        public static int Sum(int a, int b) => a + b;
        public static int Difference(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
    }
    
    public class WrongInputException : Exception {
        public override string ToString() {
            return $"{base.ToString()}\nInput must be int";
        }
    }
}