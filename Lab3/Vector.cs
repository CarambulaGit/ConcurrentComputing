using System;
using System.Linq;
using static Lab3.Lab3;

namespace Lab3 {
    public class Vector {
        private int[] _vect;

        public Vector(int[] arr) => _vect = arr;

        public Vector(int n) {
            _vect = new int[n];
            var r = new Random();
            for (var i = 0; i < n; ++i)
                _vect[i] = r.Next(20);
        }

        public void FillVectorWithNumber(int number) {
            for (var i = 0; i < N; i++) {
                _vect[i] = number;
            }
        }


        public int GetElem(int index) => _vect[index];

        public Vector Sum(Vector v) {
            var n = _vect.Length;
            var vect = new int[n];
            for (var i = 0; i < n; ++i)
                vect[i] = _vect[i] + v._vect[i];
            return new Vector(vect);
        }

        public Vector Sub(Vector v) {
            var n = _vect.Length;
            var vect = new int[n];
            for (var i = 0; i < n; ++i)
                vect[i] = _vect[i] - v._vect[i];
            return new Vector(vect);
        }

        public int Multiply(Vector v) {
            var n = _vect.Length;
            var res = 0;
            for (var i = 0; i < n; ++i) {
                res += _vect[i] * v._vect[i];
            }

            return res;
        }

        public Vector Multiply(int a) {
            var n = _vect.Length;
            var vect = new int[n];
            for (var i = 0; i < n; ++i) {
                vect[i] = _vect[i] * a;
            }

            return new Vector(vect);
        }

        public Vector Sort() {
            var buf = (Vector) _vect.Clone();
            Array.Sort(buf._vect);
            return buf;
        }

        public override string ToString() {
            var res = "";
            var n = _vect.Length;
            for (var i = 0; i < n; ++i)
                res += _vect[i] + " ";
            return res;
        }
    }
}