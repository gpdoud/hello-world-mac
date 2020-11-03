using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {
            HelloWorldLibrary.Lib.Get();
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"{HelloWorldLibrary.Lib.About()}");
        }
    }
}
