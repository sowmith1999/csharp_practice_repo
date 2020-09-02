using System;

namespace practice
{
    class ArrayComparision
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a != null && b != null && (a.Length == b.Length))
            {
                Array.Sort(a);
                Array.Sort(b);
                for (var i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                    Console.WriteLine(b[i]);
                    if (a[i] * a[i] == b[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}