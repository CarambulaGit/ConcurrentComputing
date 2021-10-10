using System;

namespace Lab2 {
    public class Function1 : Function {
        Vector b = new Vector(Lab2.N);
        Vector c = new Vector(Lab2.N);
        Vector d = new Vector(Lab2.N);
        Matrix md = new Matrix(Lab2.N, Lab2.N);
        Matrix me = new Matrix(Lab2.N, Lab2.N);

        public Function1(FillType type) : base(type) { }
        public Function1(int num) : base(num) { }

        public override void FillWithRandom() {
            b.FillWithRandom();
            c.FillWithRandom();
            d.FillWithRandom();
            md.FillWithRandom();
            me.FillWithRandom();
        }

        public override void FillWithNumber(int num = 1) {
            b.FillWithNumber(num);
            c.FillWithNumber(num);
            d.FillWithNumber(num);
            md.FillWithNumber(num);
            me.FillWithNumber(num);
        }

        public override void FillWithInput() {
            Console.WriteLine("Enter B:");
            b.FillWithInput();
            Console.WriteLine("Enter C:");
            c.FillWithInput();
            Console.WriteLine("Enter D:");
            d.FillWithInput();
            Console.WriteLine("Enter MD:");
            md.FillWithInput();
            Console.WriteLine("Enter ME:");
            me.FillWithInput();
        }

        public override void Run() {
            // A = B + C + D * (MD * ME)
            // lock (Lab3.Locker) {
                // Thread.Sleep(1000);
                Console.WriteLine("Function 1 started");
                var result = b + c + d * (md * me);
                Console.WriteLine("Function 1 result:\n" + result);
                Console.WriteLine("Function 1 finished");
            // }
        }
    }
}