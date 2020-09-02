using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace practice
{
    public class NextSmallNumber
    {
        public static long NextSmaller(long n)
        {
            //var charArray = n.ToString().ToCharArray();
            //var intArray = new int[charArray.Length];
            //for (var i = 0; i < charArray.Length; i++)
            //{
            //    intArray[i] = Convert.ToInt32(charArray[i]);
            //}


            int[] intArray = Array.ConvertAll(n.ToString().ToArray(), x => (int)x - 48);
            //foreach (var i in intArray)
            //{
            //    Console.WriteLine(i);
            //}
            var length = intArray.Length;
            var X = 0;
            var xIndex = 0;
            for (var i = length-1; i>=0; i--)
            {
                for (var m = i; m >= 0; m--)
                {
                    if (intArray[i] > intArray[m])
                    {
                         X = intArray[i];
                         xIndex = i;
                        break;
                    }
                }

                if (X != 0)
                {
                    break;
                }
            }

            var Y = 0;
            var yIndex = 0;
            for (var i = xIndex-1; i >= 0; i--)
            {
                for (var m = i; m >= 0; m--)
                {
                    if (intArray[i] < X && intArray[i] > intArray[m])
                    {
                        Y = intArray[i];
                        yIndex = i;
                        continue;
                    }
                    else
                    {
                        Y = 0;
                        break;
                    }
                }

                if (Y != 0)
                {
                    break;
                }
            }

            intArray[xIndex] = X;
            intArray[xIndex] = intArray[yIndex];
            intArray[yIndex] = Y;
            return Convert.ToInt64(String.Join(",", intArray.Select(p => p.ToString()).ToArray()));

        }
    }
}