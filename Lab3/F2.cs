using System;

namespace Lab2 {
    public class Function2 : Function {
        Matrix mf = new Matrix(Lab2.N, Lab2.N);
        Matrix mh = new Matrix(Lab2.N, Lab2.N);
        Matrix mk = new Matrix(Lab2.N, Lab2.N);

        public Function2(FillType type) : base(type) { }
        public Function2(int num) : base(num) { }

        public override void FillWithRandom() {
            mf.FillWithRandom();
            mh.FillWithRandom();
            mk.FillWithRandom();
        }

        public override void FillWithNumber(int num = 2) {
            mf.FillWithNumber(num);
            mh.FillWithNumber(num);
            mk.FillWithNumber(num);        
        }

        public override void FillWithInput() {
            Console.WriteLine("Enter MF:");
            mf.FillWithInput();
            Console.WriteLine("Enter MH:");
            mh.FillWithInput();
            Console.WriteLine("Enter MK:");
            mk.FillWithInput();        
        }

        public override void Run() {
            // MG = Sort(MF - MH * MK) 
            // lock (Lab3.Locker) {
                // Thread.Sleep(1000);
                Console.WriteLine("Function 2 start");
                var result = (mf - mh * mk).Sort();
                Console.WriteLine("Function 2 result:\n" + result);
                Console.WriteLine("Function 2 finished\n");
            // }
        }
    }
}