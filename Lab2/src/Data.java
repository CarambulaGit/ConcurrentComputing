import java.util.Arrays;
import java.util.Objects;
import java.util.Random;
import java.util.Scanner;

public class Data {
    private int n;

    public Data(int n) {
        this.n = n;
    }

    public int getN() {
        return n;
    }

    public void setN(int n) {
        this.n = n;
    }

    // F1 A = B + C + D * (MD * ME)
    public int[] func1(int[] b, int[] c, int[] d, int[][] md, int[][] me) {
        return vectorAdd(Objects.requireNonNull(vectorAdd(b, c)), vectorMatrixMult(d, matrixMult(md, me)));
    }

    // F2 MG = sort(MF - MH * MK)
    public int[][] func2(int[][] mf, int[][] mh, int[][] mk) {
        return matrixSort(Objects.requireNonNull(matrixDiff(mf, matrixMult(mh, mk))));
    }

    // F3 S = sort(O * MO) * (MS * MT)
    public int[] func3(int[] o, int[][] mo, int[][] ms, int[][] mt) {
        return vectorMatrixMult(Objects.requireNonNull(vectorSort(vectorMatrixMult(o, mo))), matrixMult(ms, mt));
    }

    public int[] vectorInput() {
        int[] input = new int[n];
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < input.length; i++) {
            input[i] = scanner.nextInt();
        }
        return input;
    }

    public int[] vectorRandom() {
        int[] randVector = new int[n];
        Random random = new Random();
        for (int i = 0; i < randVector.length; i++) {
            randVector[i] = random.nextInt(10);

        }
        return randVector;
    }

    public void vectorOutput(int[] vector) {
        for (int i1 : vector) {
            System.out.println(i1);
        }
    }

    public int[][] matrixInput() {
        int[][] matrix = new int[n][n];
        Scanner scanner = new Scanner(System.in);
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = scanner.nextInt();
            }
        }
        return matrix;
    }

    public int[][] matrixNum(int num) {
        int[][] matrix = new int[n][n];
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = num;
            }
        }
        return matrix;
    }

    public int[][] matrixOne() {
        return matrixNum(1);
    }

    public int[] vectorNum(int num) {
        int[] vector = new int[n];
        for (int i = 0; i < vector.length; i++) {
            vector[i] = num;
        }
        return vector;
    }

    public int[] vectorOne() {
        return vectorNum(1);
    }

    public int[][] matrixRandom() {
        int[][] randMatrix = new int[n][n];
        Random random = new Random();
        for (int i = 0; i < randMatrix.length; i++) {
            for (int j = 0; j < randMatrix[i].length; j++) {
                randMatrix[i][j] = random.nextInt(60);
            }
        }
        return randMatrix;
    }

    public void matrixOutput(int[][] matrix) {
        for (int[] row : matrix) {
            System.out.println(Arrays.toString(row));
        }
    }

    private int findMax(int[] array) {
        int[] res = Arrays.copyOf(array, n);
        Arrays.sort(res);
        return res[res.length - 1];
    }

    private int[] vectorSort(int[] a) {
        Arrays.sort(a);
        return a;
    }

    private int[] vectorAdd(int[] first, int[] second) {
        if (first.length != n || second.length != n) {
            return null;
        }
        int[] res = new int[n];
        for (int i = 0; i < n; i++) {
            res[i] = first[i] + second[i];
        }
        return res;
    }

    private int[] vectorDiff(int[] a, int[] b) {
        if (a.length != n || b.length != n) {
            return null;
        }
        int[] c = new int[n];
        for (int i = 0; i < n; i++) {
            c[i] = a[i] - b[i];
        }
        return c;
    }

    private int[] vectorMult(int[] a, int[] b) {
        if (b.length != n || a.length != n) {
            return null;
        }
        int[] c = new int[n];
        for (int i = 0; i < n; i++) {
            c[i] = a[i] * b[i];
        }
        return c;
    }

    private int[] vectorMatrixMult(int[] a, int[][] ma) {
        if (a.length != n || ma.length != n) {
            return null;
        }
        int[] c = new int[n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                c[i] += a[j] * ma[i][j];
            }
        }
        return c;
    }

    private int[][] matrixMult(int[][] ma, int[][] mb) {
        if (ma.length != n || mb.length != n) {
            return null;
        }
        int[][] c = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < n; k++) {
                    c[i][j] += ma[i][k] * mb[k][j];
                }
            }
        }
        return c;
    }

    private int[][] matrixAdd(int[][] ma, int[][] mb) {
        if (ma.length != n || mb.length != n) {
            return null;
        }
        int[][] c = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                c[i][j] += ma[i][j] + mb[i][j];
            }
        }
        return c;
    }

    private int[][] matrixDiff(int[][] ma, int[][] mb) {
        if (ma.length != n || mb.length != n) {
            return null;
        }
        int[][] c = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                c[i][j] = ma[i][j] - mb[i][j];
            }
        }
        return c;
    }

    private int[] intVectorMult(int a, int[] b) {
        int[] c = new int[n];
        for (int i = 0; i < n; i++) {
            c[i] = a * b[i];
        }
        return c;
    }

    private int[][] intMatrixMult(int a, int[][] b) {
        int[][] c = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                c[i][j] = a * b[i][j];
            }
        }
        return c;
    }

    private int[][] matrixTransp(int[][] ma) {
        int buf;
        for (int i = 0; i < ma.length; i++) {
            for (int j = 0; j <= i; j++) {
                buf = ma[i][j];
                ma[i][j] = ma[j][i];
                ma[j][i] = buf;
            }
        }
        return ma;
    }

    private int[][] matrixSort(int[][] ma) {
        for (int[] m : ma) {
            Arrays.sort(m);
        }
        return ma;
    }

}
