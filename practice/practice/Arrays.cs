using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Arrays
    {
        
        public static void Array1()
        {
            ////int[] Numbers = new int[3];
            //var Numbers = new int[3];
            ////var Numbers = new[]{1,2,3};
            //Numbers[0] = 1;

            //Console.WriteLine(Numbers[0]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "sowmith", "yamini", "sowmith" };
            ////var names = new[] {"sowmith", "yamini", "sowmith"};
            
            var numbers = new[] {1,7,10,6,8,4};

            //Length
            Console.WriteLine(numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine(index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear():");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            var another = new int[4];
            Array.Copy(numbers, another, 4);
            Console.WriteLine("effect of Copy():");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
