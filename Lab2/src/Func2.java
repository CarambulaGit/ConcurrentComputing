import java.util.Arrays;

public class Func2 extends Func {

    private int[][] MF;
    private int[][] MH;
    private int[][] MK;

    public Func2(String name, int priority, Data data) {
        super(name, priority, data);
    }

    public void randomFill() {
        MF = data.matrixRandom();
        MH = data.matrixRandom();
        MK = data.matrixRandom();
        filled = true;
    }

    public void inputFill() {
        System.out.println("Print MF");
        MF = data.matrixInput();
        System.out.println("Print MH");
        MH = data.matrixInput();
        System.out.println("Print MK");
        MK = data.matrixInput();
        filled = true;
    }

    public void oneFill() {
        MF = data.matrixOne();
        MH = data.matrixOne();
        MK = data.matrixOne();
        filled = true;
    }

    // MG = sort(MF - MH * MK)
    @Override
    public void run() {
        System.out.println("Func 2 started");
        super.run();
        try {
            int[][] result = data.func2(MF, MH, MK);
            sleep(100);
            System.out.println("Func2 result: " + Arrays.deepToString(result));
            System.out.println("Func 2 finished");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
