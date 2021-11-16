package com.company;

public class Thread4 extends Thread {
    public int[][] MF;
    public int[] E;

    @Override
    public void run() {
        MF = Utils.MatrixInput();
//        MF = Utils.MatrixFill(1);
//        E = Utils.VectorInput();
        E = Utils.VectorFill(1);
    }
}
