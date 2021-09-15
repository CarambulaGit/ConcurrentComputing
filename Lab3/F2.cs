using System;
using System.Threading;
using static Lab3.Lab3;

namespace Lab3
{
    public class Function2
    {
        public void Run()
        {
            // F2 2.2   MF = MG*(MK*ML) - MK 
             lock (Lab3.Locker)
             {
                
                //Thread.Sleep(1000);
                var mg = new Matrix(N);
                var mk = new Matrix(N);
                var ml = new Matrix(N);
                
                Matrix result;

                mg.FillMatrixWithNumber(1);
                mk.FillMatrixWithNumber(1);
                ml.FillMatrixWithNumber(1);

                Console.WriteLine("Function 2 start");
                result = mg.Multiply(mk.Multiply(ml)).Sub(mk);

                Console.WriteLine("Function 2 result \n" + result.ToString());
                Console.WriteLine("Function 2 end \n");
             }
        }
    }

}
