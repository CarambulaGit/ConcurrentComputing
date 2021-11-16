package com.company;

public class Main {

    public static void main(String[] args) {
        Utils.n = 3;
        Thread1 T1 = new Thread1();
        Thread2 T2 = new Thread2();
        Thread3 T3 = new Thread3();
        Thread4 T4 = new Thread4();

        T1.start();
        T2.start();
        T3.start();
        T4.start();

        try {
            T1.join();
            T2.join();
            T3.join();
            T4.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        int[] Z = Utils.VectorAdd(Utils.VectorMatrixMult(T2.X, Utils.MatrixMult(T1.MA, T3.MS)),
                Utils.VectorMatrixMult(Utils.VectorAdd(T2.X, T4.E), Utils.IntMatrixMult(Utils.FindMin(T2.X), T4.MF)));
        Utils.VectorOutput(Z);
    }
}


