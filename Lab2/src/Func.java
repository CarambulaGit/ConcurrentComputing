public abstract class Func extends Thread {
    protected Data data;
    protected boolean filled;

    public Func(String name, int priority, Data data) {
        setName(name);
        setPriority(priority);
        this.data = data;
    }

    public Data getData() {
        return data;
    }

    public void setData(Data data) {
        this.data = data;
    }

    public abstract void randomFill();

    public abstract void inputFill();

    public abstract void oneFill();

    @Override
    public void run() {
        if (!filled) oneFill();
    }
}

