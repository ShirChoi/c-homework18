using System;
namespace Sarvar {
    public class MyList<T> {
        private T[] mArray;
        public int Length => mArray.Length;

        public MyList() {
            mArray = new T[0];
        }

        public void Add(T element) {
            Array.Resize(ref mArray, mArray.Length + 1);

            mArray[mArray.Length - 1] = element;
        }

        public T this[int index] {
            get {
                return mArray[index];
            }
            set {
                mArray[index] = value;
            }
        }
    }
}