using System;
using System.Collections.Generic;

namespace Sarvar {
    public class KeyValPair<TKey, TVal> {
        public TKey key;
        public TVal value;

        public KeyValPair() {}
        public KeyValPair(TKey key, TVal val) {
            this.key = key;
            this.value = val;
        }
    }

    public class MyDictionary<TKey, TVal> {
        private List<TKey> _usedKeys;
        private List<KeyValPair<TKey, TVal>> mList;
        public int Length => mList.Count;
        public MyDictionary() {
            _usedKeys = new List<TKey>();
            mList = new List<KeyValPair<TKey, TVal>>();
        }

        public void Add(TKey key, TVal value) {
            if(_usedKeys.Contains(key)) {
                throw new Exception($"key with value{key.ToString()} is already used!");
            }
            _usedKeys.Add(key);
            mList.Add(new KeyValPair<TKey, TVal>(key, value));
        }

        public TVal this[TKey key] {
            get {
                foreach(KeyValPair<TKey, TVal> pair in mList) 
                    if(pair.key.Equals(key))
                        return pair.value;
                
                throw new Exception($"key: {key.ToString()} is not contained in dictionary");
            }
            set {
                for(int i = 0; i < mList.Count; i++)
                    if(mList[i].key.Equals(key)){
                        mList[i].value = value;

                        return;
                    }

                throw new Exception($"key: {key.ToString()} is not contained in dictionary");
            }
        }

    }
}