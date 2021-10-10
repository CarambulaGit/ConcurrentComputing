using System;
using System.Linq;

namespace Lab2 {
    public class Vector {
        private int[] _vect;

        public Vector(int[] arr) => _vect = arr;

        public Vector(int n) {
            _vect = new int[n];
            FillWithNumber(1);
        }

        public static Vector operator *(Vector a, Matrix ma) {
            var n = ma.GetLenFirstDimension();
            var m = ma.GetLenSecondDimension();
            if (a.GetLength() != n) {
                throw new MatrixLengthException();
            }

            var vect = new int[m];
            for (var i = 0; i < m; i++) {
                vect[i] = 0;
                for (var j = 0; j < m; j++) {
                    vect[i] += ma.GetElem(i, j) * a.GetElem(j);
                }
            }

            return new Vector(vect);
        }

        public static Vector operator *(Vector a, Vector b) {
            return new Vector(VectorsOperation(a, b, DefaultOperations.Multiply));
        }

        public static Vector operator *(Vector a, int b) {
            var n = a._vect.Length;
            var vect = new int[n];
            for (var i = 0; i < n; i++) {
                vect[i] = a._vect[i] * b;
            }

            return new Vector(vect);
        }

        public static Vector operator +(Vector a, Vector b) {
            return new Vector(VectorsOperation(a, b, DefaultOperations.Sum));
        }

        public static Vector operator -(Vector a, Vector b) {
            return new Vector(VectorsOperation(a, b, DefaultOperations.Difference));
        }

        private static int[] VectorsOperation(Vector a, Vector b, Func<int, int, int> operation) {
            var n = a._vect.Length;
            if (n != b._vect.Length) {
                throw new VectorLengthException();
            }

            var vect = new int[n];
            for (var i = 0; i < n; i++) {
                vect[i] = operation(a._vect[i], b._vect[i]);
            }

            return vect;
        }

        public int GetLength() => _vect.Length;

        public void FillWithNumber(int number) {
            var n = Lab2.N;
            for (var i = 0; i < n; i++) {
                _vect[i] = number;
            }
        }

        public void FillWithRandom() {
            var r = new Random();
            var n = _vect.Length;
            for (var i = 0; i < n; i++)
                _vect[i] = r.Next(20);
        }

        public void FillWithInput() {
            var n = _vect.Length;
            for (var i = 0; i < n; i++) {
                if (!int.TryParse(Console.ReadLine(), out _vect[i])) {
                    throw new WrongInputException();
                }
            } 
        }

        public int GetElem(int index) => _vect[index];

        public Vector Sort() {
            var buf = new Vector((int[])_vect.Clone()); 
            Array.Sort(buf._vect);
            return buf;
        }

        public int Max() => _vect.Max();

        public int Min() => _vect.Min();

        public override string ToString() {
            var res = "";
            var n = _vect.Length;
            for (var i = 0; i < n; ++i)
                res += _vect[i] + "\t";
            return res;
        }
    }

    public class VectorLengthException : Exception {
        public override string ToString() {
            return $"{base.ToString()}\nVectors must have same length";
        }
    }
}