using System;
using System.Threading;
using static Lab3.Lab3;

namespace Lab3
{
    public class Function3
    {
        public void Run()
        {
            lock (Lab3.Locker)
            {
                // F3 3.14  T = (O + P) * (ML * MS)
                
                //Thread.Sleep(1000);
                var p = new Vector(N);
                var o = new Vector(N);
                var ml = new Matrix(N);
                var ms = new Matrix(N);
                Vector result;

                p.FillVectorWithNumber(1);
                o.FillVectorWithNumber(1);
                ml.FillMatrixWithNumber(1);
                ms.FillMatrixWithNumber(1);

                Console.WriteLine("Function 3 start");
                result = ml.Multiply(ms).Multiply(o.Sum(p));
                Console.WriteLine("Function 3 result \n" + result.ToString());
                Console.WriteLine("Function 3 end \n");
            }
        }
    }

}
