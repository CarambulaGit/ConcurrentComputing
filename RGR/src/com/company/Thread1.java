package com.company;

public class Thread1 extends Thread {
    public int[][] MA;

    @Override
    public void run() {
//        MA = Utils.MatrixInput();
        MA = Utils.MatrixFill(1);
    }
}
