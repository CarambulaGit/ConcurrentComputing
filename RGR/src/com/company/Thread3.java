package com.company;

public class Thread3 extends Thread {
    public int[][] MS;

    @Override
    public void run() {
//        MS = Utils.MatrixInput();
        MS = Utils.MatrixFill(1);
    }
}
