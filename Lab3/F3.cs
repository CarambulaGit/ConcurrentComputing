using System;

namespace Lab2 {
    public class Function3 : Function {
        Vector o = new Vector(Lab2.N);
        Matrix mo = new Matrix(Lab2.N, Lab2.N);
        Matrix ms = new Matrix(Lab2.N, Lab2.N);
        Matrix mt = new Matrix(Lab2.N, Lab2.N);
        public Function3(FillType type) : base(type) { }
        public Function3(int num) : base(num) { }

        public override void FillWithRandom() {
            o.FillWithRandom();
            mo.FillWithRandom();
            ms.FillWithRandom();
            mt.FillWithRandom();
        }

        public override void FillWithNumber(int num = 0) {
            o.FillWithNumber(num);
            mo.FillWithNumber(num);
            ms.FillWithNumber(num);
            mt.FillWithNumber(num);
        }

        public override void FillWithInput() {
            Console.WriteLine("Enter O:");
            o.FillWithInput();
            Console.WriteLine("Enter MO:");
            mo.FillWithInput();
            Console.WriteLine("Enter MS:");
            ms.FillWithInput();
            Console.WriteLine("Enter MT:");
            mt.FillWithInput();
        }

        public override void Run() {
            // S = Sort(O * MO) * (MS * MT) 
            // lock (Lab3.Locker) {
                // Thread.Sleep(1000);
                Console.WriteLine("Function 3 start");
                var result = (o * mo).Sort() * (ms * mt);
                Console.WriteLine("Function 3 result:\n" + result);
                Console.WriteLine("Function 3 finished\n");
            // }
        }
    }
}