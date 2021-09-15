import java.util.Arrays;

public class Func3 extends Func {
    private int[] O;
    private int[][] MO;
    private int[][] MS;
    private int[][] MT;

    public Func3(String name, int priority, Data data) {
        super(name, priority, data);
    }

    public void randomFill() {
        O = data.vectorRandom();
        MO = data.matrixRandom();
        MS = data.matrixRandom();
        MT = data.matrixRandom();
        filled = true;
    }

    public void inputFill() {
        System.out.println("Print O");
        O = data.vectorInput();
        System.out.println("Print MO");
        MO = data.matrixInput();
        System.out.println("Print MS");
        MS = data.matrixInput();
        System.out.println("Print MT");
        MT = data.matrixInput();
        filled = true;
    }

    public void oneFill() {
        O = data.vectorOne();
        MO = data.matrixOne();
        MS = data.matrixOne();
        MT = data.matrixOne();
        filled = true;
    }

    // S = sort(O * MO) * (MS * MT)
    @Override
    public void run() {
        System.out.println("Func 3 started");
        super.run();
        try {
            int[] result = data.func3(O, MO, MS, MT);
            sleep(100);
            System.out.println("Func3 result: " + Arrays.toString(result));
            System.out.println("Func 3 finished");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}