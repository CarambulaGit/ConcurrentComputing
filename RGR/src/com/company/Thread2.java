package com.company;

public class Thread2 extends Thread {
    public int[] X;

    @Override
    public void run() {
        X = Utils.VectorInput();
//        X = Utils.VectorFill(1);
    }
}
