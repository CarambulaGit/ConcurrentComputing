using System;

namespace Lab2 {
    public class Matrix {
        private int[,] _matr;

        public Matrix(int n, int m) {
            _matr = new int[n, m];
            FillWithNumber(1);
        }

        public Matrix(int[,] arr) {
            _matr = (int[,]) arr.Clone();
        }

        public static Matrix operator *(Matrix ma, Matrix mb) {
            if (ma._matr.GetLength(1) != mb._matr.GetLength(0)) {
                throw new MatrixLengthException();
            }

            var n = ma._matr.GetLength(0);
            var m = mb._matr.GetLength(1);
            var matr = new int[n, m];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < m; ++j) {
                    matr[i, j] = 0;
                    for (var k = 0; k < n; ++k) {
                        matr[i, j] += ma._matr[i, k] * mb._matr[k, j];
                    }
                }
            }

            return new Matrix(matr);
        }

        public static Matrix operator *(Matrix ma, Vector a) {
            var n = ma._matr.GetLength(0);
            var m = a.GetLength();

            if (ma._matr.GetLength(1) != 1) {
                throw new MatrixLengthException();
            }

            var matr = new int[n, m];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    matr[i, j] += ma._matr[i, 0] * a.GetElem(j);
                }
            }

            return new Matrix(matr);
        }

        public static Matrix operator *(Matrix ma, int a) {
            var n = ma._matr.GetLength(0);
            var m = ma._matr.GetLength(1);
            var matr = new int[n, m];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    matr[i, j] = a * ma._matr[i, j];
                }
            }

            return new Matrix(matr);
        }

        public static Matrix operator +(Matrix ma, Matrix mb) {
            return new Matrix(MatrixOperation(ma, mb, DefaultOperations.Sum));
        }

        public static Matrix operator -(Matrix ma, Matrix mb) {
            return new Matrix(MatrixOperation(ma, mb, DefaultOperations.Difference));
        }

        private static int[,] MatrixOperation(Matrix ma, Matrix mb, Func<int, int, int> operation) {
            var n = ma._matr.GetLength(0);
            var m = ma._matr.GetLength(1);
            if (n != mb._matr.GetLength(0) || m != mb._matr.GetLength(1)) {
                throw new MatrixLengthException();
            }

            var matr = new int[n, m];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    matr[i, j] = operation(ma._matr[i, j], mb._matr[i, j]);
                }
            }

            return matr;
        }

        public int GetLenFirstDimension() => _matr.GetLength(0);

        public int GetLenSecondDimension() => _matr.GetLength(1);

        public void FillWithNumber(int number) {
            var n = Lab2.N;
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    _matr[i, j] = number;
                }
            }
        }

        public void FillWithRandom() {
            var n = _matr.GetLength(0);
            var m = _matr.GetLength(1);
            var r = new Random();
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    _matr[i, j] = r.Next(20);
                }
            }
        }

        public void FillWithInput() {
            var n = _matr.GetLength(0);
            var m = _matr.GetLength(1);
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    if (!int.TryParse(Console.ReadLine(), out _matr[i, j])) {
                        throw new WrongInputException();
                    }
                }
            }
        }

        public int GetElem(int i, int j) {
            return _matr[i, j];
        }

        public int GetSize() {
            return _matr.GetLength(0);
        }

        public int Min() {
            var res = _matr[0, 0];
            var n = _matr.GetLength(0);
            var m = _matr.GetLength(1);
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    if (res < _matr[i, j]) {
                        res = _matr[i, j];
                    }
                }
            }

            return res;
        }

        public int Max() {
            var res = _matr[0, 0];
            var n = _matr.GetLength(0);
            var m = _matr.GetLength(1);
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    if (res > _matr[i, j]) {
                        res = _matr[i, j];
                    }
                }
            }

            return res;
        }

        public Vector GetVectorByRow(int indexOfRow) {
            var length = _matr.GetLength(1);
            var vect = new int[length];
            for (var j = 0; j < length; j++) {
                vect[j] = _matr[indexOfRow, j];
            }

            return new Vector(vect);
        }

        public Matrix Sort() {
            var n = _matr.GetLength(0);
            var m = _matr.GetLength(1);
            var matr = new Matrix(n, m);
            for (var i = 0; i < n; i++) {
                var sortedVect = GetVectorByRow(i).Sort();
                for (var j = 0; j < m; j++) {
                    matr._matr[i, j] = sortedVect.GetElem(j);
                }
            }

            return matr;
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

    public class MatrixLengthException : Exception {
        public override string ToString() {
            return $"{base.ToString()}\nMatrices must have same length";
        }
    }
}