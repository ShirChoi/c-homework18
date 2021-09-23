using System;
using System.Collections.Generic;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            Sarvar.MyDictionary<double, int> dict = new Sarvar.MyDictionary<double, int>();

            dict.Add(1.5, 1);
            dict[1.5] =123;
            System.Console.WriteLine(dict[1.5]);
        }
    }
}
