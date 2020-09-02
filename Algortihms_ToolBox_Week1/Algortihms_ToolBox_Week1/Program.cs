using System;

namespace Algortihms_ToolBox_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = Console.ReadLine().Split(' ');
            var input = new long[n];
            for(var f=0;f<k.Length; f++)
            {
                input[f] = Int64.Parse(k[f]);
            }
            long max1 = 0;
            var max1index = 0;
            for (var f = 0; f < k.Length; f++)
            {
                if(max1<input[f])
                {
                    max1 = input[f];
                    max1index = f;
                }
            }
            long max2 = 0;
            for (var f = 0; f < k.Length; f++)
            {
                if (max2 < input[f] && max1index!=f)
                {
                    max2 = input[f];
                }
            }
            Console.WriteLine(max1*max2);
        }
        
    }
}
