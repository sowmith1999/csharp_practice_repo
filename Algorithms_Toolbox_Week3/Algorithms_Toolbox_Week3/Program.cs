using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Algorithms_Toolbox_Week3
{
    class SignaturesCollection
    {
        public static int CollectSignatures()
        {
            var n = int.Parse(Console.ReadLine());
            long[,] SegmentArray = new long[n, 2];
            for (var i = 0; i < n; i++)
            {
                var k = Console.ReadLine().Split(' ');
                SegmentArray[i, 0] = long.Parse(k[0]);
                SegmentArray[i, 1] = long.Parse(k[1]);
            }
            //finding intersection
            long[] firstsection = new long[2];
            long[] secondsection = new long[2];
            long[] intersection = new long[2];
            var matchingPoints = new List<long>();
            var sortedarray = new long[n, 2];
            long max = 0;
            var maxindex = 0;
            for(var i=0;i<n;i++)
            {
                for (var f = 0; i < SegmentArray.Length; i++)
                {
                    if (SegmentArray[f,0] > max)
                    {
                        max = SegmentArray[f,0];
                        maxindex = f;
                    }

                }
                sortedarray[maxindex, 0] = SegmentArray[maxindex, 0];
                sortedarray[maxindex, 1] = SegmentArray[maxindex, 1];
                SegmentArray[maxindex, 0] = 0;
                SegmentArray[maxindex, 1] = 0;
                max = 0;
            }
            for(var i=0;i<n;i++)
            {
                Console.Write(sortedarray[i,0]);
                Console.Write(sortedarray[i,1]);
                Console.WriteLine();
            }
            //for (var p = 0; p < n - 1; p++)
            //{
            //    if (p == 0)
            //    {
            //        for (var i = 0; i < 2; i++)
            //        {
            //            firstsection[i] = SegmentArray[0, i];
            //            secondsection[i] = SegmentArray[1, i];
            //        }

            //    }
            //    else
            //    {
            //        if (intersection[0] == 0 && intersection[1] == 0)
            //        {
            //            for (var i = 0; i < 2; i++)
            //            {
            //                firstsection[i] = SegmentArray[p, i];
            //                secondsection[i] = SegmentArray[p + 1, i];
            //            }

            //        }
            //        else
            //        {
            //            for (var i = 0; i < 2; i++)
            //            {

            //                secondsection[i] = SegmentArray[p + 1, i];
            //            }
            //            firstsection = intersection;

            //        }
            //    }
            //    long a1 = firstsection[0];
            //    long a2 = secondsection[0];
            //    long b1 = firstsection[1];
            //    long b2 = secondsection[1];

            //    if (a1 == a2 && b1 == b2)
            //    {
            //        intersection = firstsection;
            //    }
            //    else if (a1 <= a2 && b1 >= a2)
            //    {
            //        intersection[0] = a2;
            //        if (b2 >= b1 || b1==a2)
            //        {
            //            intersection[1] = b1;
            //        }
            //        else if (b2 < b1)
            //        {
            //            intersection[1] = b2;
            //        }
                    
            //    }
            //    else if (a2 > b1)
            //    {
            //        //Console.WriteLine("No Intersection");
            //        if(p==n-2)
            //        {
            //            matchingPoints.Add(b1);
            //            matchingPoints.Add(b2);
            //            break;
            //        }
            //        matchingPoints.Add(b1);
            //        intersection[0] = 0;
            //        intersection[1] = 0;
            //    }
            //    if(p==n-2)
            //    {
            //        matchingPoints.Add(intersection[1]);
            //    }

            //}
            //Console.WriteLine(matchingPoints.Count);
            //foreach (var k in matchingPoints)
            //{
            //    Console.Write(k + " ");
            //}
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine(MaxAdvertisementRevenue());
            //Console.WriteLine(MaxValueOfLoot());
            SignaturesCollection.CollectSignatures();


        }

        static long MaxAdvertisementRevenue()
        {
            int n = int.Parse(Console.ReadLine());
            var k = Console.ReadLine().Split(' ');
            var z = Console.ReadLine().Split(' ');
            var profits = new long[n];
            var clicks = new long[n];
            for (var p = 0; p < n; p++)
            {
                profits[p] = Int64.Parse(k[p]);
                clicks[p] = Int64.Parse(z[p]);
            }
            Array.Sort(profits);
            Array.Sort(clicks);
            long sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum += (profits[i] * clicks[i]);
            }


            return sum;
        }
        static int CarFuelRefill()
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var k = Console.ReadLine().Split(' ');
            var inputs = new int[n + 2];
            inputs[0] = 0;
            for (var p = 0; p < n; p++)
            {
                inputs[p + 1] = Int32.Parse(k[p]);
            }
            inputs[n + 1] = d;

            var currentrefil = 0;
            var lastrefil = 0;
            var numrefil = 0;
            while (currentrefil <= n)
            {
                lastrefil = currentrefil;
                //do
                //{
                //    currentrefil++;
                //}while(currentrefil < n && inputs[currentrefil] - inputs[lastrefil] < m)
                for (var i = currentrefil; i <= n && inputs[i + 1] - inputs[lastrefil] <= m; i++)
                {
                    currentrefil++;
                }
                if (currentrefil == lastrefil)
                {
                    return -1;
                }
                if (currentrefil <= n)
                {
                    numrefil += 1;
                }
            }
            return numrefil;
        }
        static int MoneyChange(int n)
        {
            var fivecoins = 0;
            var tencoins = 0;
            var onecoins = 0;
            tencoins += n / 10;
            n = n - tencoins * 10;
            fivecoins += n / 5;
            n = n - fivecoins * 5;
            onecoins = n;
            return tencoins + fivecoins + onecoins;

        }
        static decimal MaxValueOfLoot()
        {
            var k = Console.ReadLine().Split(' ');
            var numberOfItems = Int32.Parse(k[0]);
            var sackVolume = Int32.Parse(k[1]);
            var volumeArray = new long[numberOfItems];
            var valueArray = new float[numberOfItems];
            var actualValue = new decimal[numberOfItems];
            decimal outputValue = 0M;
            for (var i = 0; i < numberOfItems; i++)
            {
                var x = Console.ReadLine().Split(' ');
                valueArray[i] = float.Parse(x[0]);
                volumeArray[i] = long.Parse(x[1]);
                actualValue[i] = (decimal)valueArray[i] / (decimal)volumeArray[i];
            }
            while (sackVolume > 0)
            {
                decimal max = 0;
                var maxindex = 0;
                for (var i = 0; i < actualValue.Length; i++)
                {
                    if (actualValue[i] > max)
                    {
                        max = actualValue[i];
                        maxindex = i;
                    }

                }
                actualValue[maxindex] = 0;
                if (sackVolume >= volumeArray[maxindex])
                {
                    outputValue += max * volumeArray[maxindex];
                    sackVolume = sackVolume - (int)volumeArray[maxindex];
                }
                else
                {
                    outputValue += max * (sackVolume);
                    sackVolume = 0;
                }

            }


            return outputValue;
        }
    }
}
