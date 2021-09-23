using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            Sarvar.MyList<int> list = new Sarvar.MyList<int>();

            list.Add(10);
            list.Add(15);
            list.Add(17);
            list.Add(1214);
            
            for(int i = 0; i < list.Length; i++) {
                System.Console.WriteLine(list[i]);
            } 
        }
    }
}
