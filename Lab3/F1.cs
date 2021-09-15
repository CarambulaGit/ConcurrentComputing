using System;
using System.Threading;

namespace Lab3
{
    public class Function1
    { 
        public void Run()
        {
            //F1  1.2 C = A + B*(MO*ME) 
           lock (Lab3.Locker)
           {
                //Thread.Sleep(1000);
                var a = new Vector(Lab3.N);
                var b = new Vector(Lab3.N);
                var mo = new Matrix(Lab3.N);
                var me = new Matrix(Lab3.N);

                a.FillVectorWithNumber(1);
                b.FillVectorWithNumber(1);
                mo.FillMatrixWithNumber(1);
                me.FillMatrixWithNumber(1);

                Console.WriteLine("Function 1 start");
                var result = a.Sum(mo.Multiply(me).Multiply(b));
                Console.WriteLine("Function 1 result \n" + result.ToString());
                Console.WriteLine("Function 1 end \n");
           }
        }
    }

}
