using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Lists
    {
        public static void List1()
        {
            var numbers=new List<int>(){1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3]{1,2,3});

            foreach(var n in numbers)
                Console.WriteLine(n);

            Console.WriteLine();
            Console.WriteLine("Index of 1:" + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1:" + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);
            numbers.Remove(1);
            foreach(var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine("remove1");
            //we cannot use remove method inside a foreach loop(why? for now dont know), to do that for works
            for (var i = 0; i <= numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(1);
                }
                
            }
            foreach (var n in numbers)
                Console.WriteLine(n);

            numbers.Clear();
            Console.WriteLine("count:" + numbers.Count);


        }

    }
}
