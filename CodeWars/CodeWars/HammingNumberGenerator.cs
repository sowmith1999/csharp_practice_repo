using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    class HammingNumberGenerator
    {
        public static long Generate(int n)
        {
            var set = new List<long> { 1 };
            var primes = new int[] { 2, 3, 5 };
            var count = 1;
            long x2=0;
            long x3=0;
            long x5=0;
            var holdList = new List<long> { 1 };
            while (count < n)
            {
                var highest = holdList[holdList.Count - 1];
                count += 1;

                foreach (var f in holdList)
                {
                    var hold2 = f * 2;
                    if (hold2 > highest)
                    {
                        x2 = hold2;
                        break;
                    }
                }
                foreach (var f in holdList)
                {
                    var hold3 = f * 3;
                    if (hold3 > highest)
                    {
                        x3 = hold3;
                        break;
                    }
                }
                foreach (var f in holdList)
                {
                    var hold5 = f * 5;
                    if (hold5 > highest)
                    {
                        x5 = hold5;
                        break;
                    }
                }
                var update= Math.Min(x2,Math.Min(x3,x5));
                holdList.Add(update);
            }
           System.Console.WriteLine(holdList[holdList.Count-1]);
            return holdList[holdList.Count-1];
        }

    }
    class MainClass {
 
        public static BigInteger Hamming(int n) {
            BigInteger two = 2, three = 3, five = 5;
            var h = new BigInteger[n];
            h[0] = 1;
            BigInteger x2 = 2, x3 = 3, x5 = 5;
            int i = 0, j = 0, k = 0;
 
            for (int index = 1; index < n; index++) {
                h[index] = BigInteger.Min(x2, BigInteger.Min(x3, x5));
                if (h[index] == x2) x2 = two * h[++i];
                if (h[index] == x3) x3 = three * h[++j];
                if (h[index] == x5) x5 = five * h[++k];
            }
            return h[n - 1];
        }
 
       
    }
}
