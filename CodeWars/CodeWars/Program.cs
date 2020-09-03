using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Program
    {
         public static void Main(string[] args) {
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, 20).ToList().Select(x => MainClass.Hamming(x))));
            Console.WriteLine(MainClass.Hamming(1691));
            Console.WriteLine(MainClass.Hamming(1000000));
        }
       
        // static void Main(string[] args)
        // {
        //     var n=int.Parse(Console.ReadLine());
        //     HammingNumberGenerator.Generate(n);
        // }
    }
}
