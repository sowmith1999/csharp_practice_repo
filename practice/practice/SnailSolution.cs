//using System;
//using System.Collections.Generic;

using System;

namespace practice
{
    public class SnailSolution
    {
        public static void spiralPrint(int m, int n, int[,] a)
        {
            int i, k = 0, l = 0;
            /* k - starting row index 
            m - ending row index 
            l - starting column index 
            n - ending column index 
            i - iterator 
            */

            while (k < m && l < n)
            {
                // Print the first row  
                // from the remaining rows 
                for (i = l; i < n; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the 
                // remaining columns 
                for (i = k; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }
                n--;

                // Print the last row from  
                // the remaining rows  
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(a[m - 1, i] + " ");
                    }
                    m--;
                }

                // Print the first column from  
                // the remaining columns 
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }
        //public static int[] Snail(int[][] array)
        //{
        //    int R = 3;
        //    int C = 6;
        //    int[,] a = { { 1, 2, 3, 4, 5, 6 },
        //        { 7, 8, 9, 10, 11, 12 },
        //        { 13, 14, 15, 16, 17, 18 } };
        //    spiralPrint(R, C, a);
        //}
    }
    //        public static void OuterRow(int[][] aley)
    //        {
    //            var totalList = new List<int>();
    //            foreach (var p in aley)
    //            {
    //                foreach (var t in p)
    //                {
    //                    totalList.Add(t);
    //                }
    //            }
    //            var lola = 0;
    //            var length = aley[0].Length;
    //            var resultArray = new int[length * length];
    //            var resultList = new List<int>();
    //            var i = 0;
    //            for (var m = 0; m < resultArray.Length; m++)
    //            {

    //                Console.WriteLine("m={0}", m);
    //                if (m == 0)
    //                    i = 0;

    //                if (i == 0)
    //                {
    //                    for (var k = 0; k < length; k++)
    //                    {
    //                        resultList.Add(totalList[k]);
    //                        Console.WriteLine("inside first for loop{0}", totalList[k]);
    //                    }

    //                    Console.WriteLine("first for loop{0}", resultList[^1]);
    //                    i = length - 1;
    //                    Console.WriteLine("i={0}", i);
    //                }

    //                //if (i == totalList.IndexOf(resultList[^1]))
    //                //{
    //                for (var k = 0; k < length - 1 - m; k++)
    //                {
    //                    resultList.Add(totalList[i + length]);
    //                    Console.WriteLine("inside for loop 2 {0}", totalList[i + length]);
    //                    i += length;
    //                }


    //                //i = totalList.IndexOf(resultList[^1]);
    //                //}
    //                if (resultList.Count == totalList.Count)
    //                {
    //                    break;
    //                }

    //                //if (i == totalList.IndexOf(resultList[^1]))
    //                //{
    //                for (var k = i - 1; k > i - length + m; k--)
    //                {
    //                    resultList.Add(totalList[k]);
    //                    Console.WriteLine("inside for loop 3 {0}", totalList[k]);
    //                }
    //                Console.WriteLine("third for loop{0}", resultList[^1]);

    //                for (var k = 0; k < length - 1 - m; k++)
    //                {
    //                    resultList.Add(totalList[i + length]);
    //                    Console.WriteLine("inside for loop 2 {0}", totalList[i + length]);
    //                    i += length;
    //                }
    //                var laley= new int[][]{}
    //            }
    //        public static int[] Snail(int[][] array)
    //        {
    //            OuterRow(array);
    //        }

    //        //public static int[] Snail(int[][] array)
    //        //{
    //        //    var totalList = new List<int>();
    //        //    foreach (var p in array)
    //        //    {
    //        //        foreach (var t in p)
    //        //        {
    //        //            totalList.Add(t);
    //        //        }
    //        //    }

    //        //    var lola = 0;
    //        //    var length = array[0].Length;
    //        //    var resultArray = new int[length * length];
    //        //    var resultList = new List<int>();
    //        //    var i = 0;
    //        //    for (var m = 0; m < resultArray.Length; m++)
    //        //    {
    //        //        Console.WriteLine("m={0}", m);
    //        //        if (m == 0)
    //        //            i = 0;

    //        //        if (i == 0)
    //        //        {
    //        //            for (var k = 0; k < length; k++)
    //        //            {
    //        //                resultList.Add(totalList[k]);
    //        //                Console.WriteLine("inside first for loop{0}", totalList[k]);
    //        //            }

    //        //            Console.WriteLine("first for loop{0}", resultList[^1]);
    //        //            i = length - 1;
    //        //            Console.WriteLine("i={0}", i);
    //        //        }

    //        //        //if (i == totalList.IndexOf(resultList[^1]))
    //        //        //{
    //        //        for (var k = 0; k < length - 1 - m; k++)
    //        //        {
    //        //            resultList.Add(totalList[i + length]);
    //        //            Console.WriteLine("inside for loop 2 {0}", totalList[i + length]);
    //        //            i += length;
    //        //        }

    //        //        if (m == 0)
    //        //        {
    //        //            i = totalList.Count - 1;
    //        //            Console.WriteLine("i={0}", i);
    //        //        }
    //        //        else if (m == 2)
    //        //        {
    //        //            i = 19-1;
    //        //            Console.WriteLine("i={0}",i);
    //        //        }
    //        //        else if (m == 3)
    //        //        {
    //        //            i = 13;
    //        //            Console.WriteLine("i={0}", i);
    //        //        }
    //        //        else if (m == 4)
    //        //        {
    //        //            i = 12;
    //        //            Console.WriteLine("i={0}", i);
    //        //        }
    //        //        else
    //        //        {
    //        //            i = (totalList.Count-1) - length*m;
    //        //            Console.WriteLine("i={0}", i);
    //        //        }
    //        //        Console.WriteLine("second for loop{0}", resultList[^1]);

    //        //        //i = totalList.IndexOf(resultList[^1]);
    //        //        //}
    //        //        if (resultList.Count == totalList.Count)
    //        //        {
    //        //            break;
    //        //        }

    //        //        //if (i == totalList.IndexOf(resultList[^1]))
    //        //        //{
    //        //        for (var k = i - 1; k > i - length + m; k--)
    //        //        {
    //        //            resultList.Add(totalList[k]);
    //        //            Console.WriteLine("inside for loop 3 {0}", totalList[k]);
    //        //        }
    //        //        Console.WriteLine("third for loop{0}", resultList[^1]);


    //        //        ////i = totalList.Count - length + 1;
    //        //        //}
    //        //        var itr = m + 1;
    //        //        totalList.Reverse();
    //        //        Console.WriteLine("reversed");

    //        //        if (itr == 1)
    //        //        {
    //        //            i = length - 1;

    //        //        }
    //        //        else if(itr%2==0)
    //        //        {
    //        //            i = (length - 1) * (itr);
    //        //            lola = i;
    //        //        }
    //        //        else
    //        //        {

    //        //            i=lola;
    //        //        }
    //        //        Console.WriteLine("i={0}", i);


    //        //    }
    //        //    foreach (var lala in resultList)
    //        //        Console.WriteLine(lala);
    //        //    return resultList.ToArray();
    //        //}
    //    }
}