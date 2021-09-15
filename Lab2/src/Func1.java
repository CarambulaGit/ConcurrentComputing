import java.util.Arrays;

public class Func1 extends Func {
    private int[] B;
    private int[] C;
    private int[] D;
    private int[][] MD;
    private int[][] ME;

    public Func1(String name, int priority, Data data) {
        super(name, priority, data);
    }

    public void randomFill() {
        B = data.vectorRandom();
        C = data.vectorRandom();
        D = data.vectorRandom();
        MD = data.matrixRandom();
        ME = data.matrixRandom();
        filled = true;
    }

    public void inputFill() {
        System.out.println("Print B");
        B = data.vectorInput();
        System.out.println("Print C");
        C = data.vectorInput();
        System.out.println("Print D");
        D = data.vectorInput();
        System.out.println("Print MD");
        MD = data.matrixInput();
        System.out.println("Print ME");
        ME = data.matrixInput();
        filled = true;
    }

    public void oneFill() {
        B = data.vectorOne();
        C = data.vectorOne();
        D = data.vectorOne();
        MD = data.matrixOne();
        ME = data.matrixOne();
        filled = true;
    }

    // A = B + C + D * (MD * ME)
    @Override
    public void run() {
        System.out.println("Func 1 started");
        super.run();
        try {
            int[] result = data.func1(B, C, D, MD, ME);
            sleep(100);
            System.out.println("Func1 result: " + Arrays.toString(result));
            System.out.println("Func 1 finished");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
