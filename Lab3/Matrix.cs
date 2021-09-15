using System;
using static Lab3.Lab3;

namespace Lab3 {
    public class Matrix {
        private int[,] _matr;

        public Matrix(int n) {
            var r = new Random();
            _matr = new int[n, n];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    _matr[i, j] = r.Next(20);
                }
            }
        }

        public Matrix(int[,] arr) {
            _matr = (int[,]) arr.Clone();
        }

        public void FillMatrixWithNumber(int number) {
            for (var i = 0; i < N; i++) {
                for (var j = 0; j < N; j++) {
                    _matr[i, j] = number;
                }
            }
        }

        public int GetElem(int i, int j) {
            return _matr[i, j];
        }

        public int GetSize() {
            return _matr.GetLength(0);
        }

        public Matrix Multiply(Matrix m) {
            var n = GetSize();
            var matr = new int[n, n];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    matr[i, j] = 0;
                    for (var k = 0; k < n; ++k) {
                        matr[i, j] += _matr[i, k] * m.GetElem(k, j);
                    }
                }
            }

            return new Matrix(matr);
        }

        public Vector Multiply(Vector v) {
            var n = GetSize();
            var matr = new int[n];
            for (var i = 0; i < n; ++i) {
                matr[i] = 0;
                for (var j = 0; j < n; ++j) {
                    matr[i] += v.GetElem(i) * _matr[i, j];
                }
            }

            return new Vector(matr);
        }

        public Matrix Multiply(int a) {
            var n = GetSize();
            var matr = new int[n, n];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    matr[i, j] = _matr[i, j] * a;
                }
            }

            return new Matrix(matr);
        }

        public Matrix Sum(Matrix m) {
            var n = GetSize();
            var matr = new int[n, n];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    matr[i, j] = _matr[i, j] + m.GetElem(i, j);
                }
            }

            return new Matrix(matr);
        }

        public Matrix Sub(Matrix m) {
            var n = GetSize();
            var matr = new int[n, n];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    matr[i, j] = _matr[i, j] - m.GetElem(i, j);
                }
            }

            return new Matrix(matr);
        }

        public int Min() {
            var res = _matr[0, 0];
            var n = GetSize();
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    if (res < _matr[i, j])
                        res = _matr[i, j];
                }
            }

            return res;
        }

        public int Max() {
            var res = _matr[0, 0];
            var n = GetSize();
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    if (res > _matr[i, j])
                        res = _matr[i, j];
                }
            }

            return res;
        }

        public override string ToString() {
            var res = "";
            var n = GetSize();
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    res += _matr[i, j] + "\t";
                }

                res += "\n";
            }

            return res;
        }
    }
}