using System;

namespace Lab2 {
    public abstract class Function {
        public enum FillType {
            Random,
            Number,
            Input
        }

        public Function(FillType type) {
            switch (type) {
                case FillType.Random:
                    FillWithRandom();
                    break;
                case FillType.Number:
                    FillWithNumber();
                    break;
                case FillType.Input:
                    FillWithInput();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public Function(int num) {
            FillWithNumber(num);
        }

        public abstract void FillWithRandom();
        public abstract void FillWithNumber(int num = 0);
        public abstract void FillWithInput();

        public abstract void Run();
    }
}