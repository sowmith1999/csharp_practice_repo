using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Algortihms_ToolBox_Week2
{
    class GCD
    {

        public static long GCDFast(long a, long b)
        {
            if (a>=b)
            {
                
            }
            else if(b>a)
            {
                var dup = a;
                a = b;
                b = dup;

            }
            if(b==0)
            {
                return a;
            }
            var d = a % b;
            return GCDFast(b, d);
        }
        //public static long LCMFast(Int64 a , Int64 b)
        //{

        //        LCMFast(a / gcd, b / gcd);
        //    }
        //    return 0;
        //}
        public static long gcf(long a, long b)
        {
            if(b>a)
            {
                var temp = b;
                b = a;
                a = temp;
            }
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static long lcm(long a, long b)
        {
            return (a / gcf(a, b)) * b;
        }
    }
    class fibonacci
    {
        public static long FastFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            long[] fibArray = new long[n+1];
            fibArray[0] = 0;
            fibArray[1] = 1;
            
            for(var i=2;i<=n;i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }
            return fibArray[n];
        }
        public static int LastDigitFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            var lastDigitArray = new int[n + 1];
            lastDigitArray[0] = 0;
            lastDigitArray[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                var str = Convert.ToString(lastDigitArray[i - 1] + lastDigitArray[i - 2]);
                lastDigitArray[i] = Convert.ToInt32(str[str.Length-1]-'0');
            }
            return lastDigitArray[n];

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());
            //Console.WriteLine(fibonacci.FastFibonacci(n));
            //Console.WriteLine(fibonacci.LastDigitFibonacci(n));
            var k = Console.ReadLine().Split(' ');
            var a = int.Parse(k[0]);
            var b = int.Parse(k[1]);

            //Console.WriteLine(GCD.GCDFast(a,b));
            Console.WriteLine(GCD.lcm(a,b));



        }
    }
}
