package com.company;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.Semaphore;

public class Utils {
    public static int n;
    private static Semaphore semaphore = new Semaphore(1);

    public static /*synchronized*/ int[] VectorInput() {
        int[] input = new int[n];
        try {
            semaphore.acquire();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter vector:");
        for (int i = 0; i < input.length; i++) {
            input[i] = scanner.nextInt();
        }
        semaphore.release();
        return input;
    }

    public static int[] VectorFill(int num) {
        int[] input = new int[n];
        Arrays.fill(input, num);
        return input;
    }

    public static /*synchronized*/ void VectorOutput(int[] vector) {
        try {
            semaphore.acquire();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println(Arrays.toString(vector));
        semaphore.release();
    }

    public static /*synchronized*/ int[][] MatrixInput() {
        int[][] matrix = new int[n][n];
        try {
            semaphore.acquire();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter matrix:");
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = scanner.nextInt();
            }
            System.out.println();
        }
        semaphore.release();
        return matrix;
    }

    public static int[][] MatrixFill(int num) {
        int[][] matrix = new int[n][n];
        for (int[] vector : matrix) {
            Arrays.fill(vector, num);
        }
        return matrix;
    }

    public static /*synchronized*/ void MatrixOutput(int[][] matrix) {
        try {
            semaphore.acquire();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        for (int[] row : matrix) {
            System.out.println(Arrays.toString(row));
        }
        semaphore.release();
    }

    public static int FindMin(int[] array) {
        int[] res = Arrays.copyOf(array, n);
        Arrays.sort(res);
        return res[0];
    }

    public static int[] VectorAdd(int[] a, int[] b) {
        if (a.length != n || b.length != n) {
            return null;
        }
        int[] res = new int[n];
        for (int i = 0; i < n; i++) {
            res[i] = a[i] + b[i];
        }
        return res;
    }

    public static int VectorMult(int[] a, int[] b) {
        if (b.length != n || a.length != n) {
            return 0;
        }
        int c = 0;
        for (int i = 0; i < n; i++) {
            c += a[i] * b[i];
        }
        return c;
    }

    public static int[] IntVectorMult(int a, int[] b) {
        int[] c = new int[n];
        for (int i = 0; i < n; i++) {
            c[i] = a * b[i];
        }
        return c;
    }

    public static int[][] MatrixMult(int[][] ma, int[][] mb) {
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

    public static int[][] IntMatrixMult(int a, int[][] b) {
        int[][] c = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                c[i][j] = a * b[i][j];
            }
        }
        return c;
    }

    public static int[] VectorMatrixMult(int[] a, int[][] ma) {
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
}
