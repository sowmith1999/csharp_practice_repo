using System;
using System.Collections.Generic;

namespace practice
{
    public class JosephusPermute
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            var lol = k-1;
            var resultList=new List<object>(){};
            var length=items.Count;
            for (var i = 0; i < length; i++)
            {
                

                if (lol>items.Count-1 && items.Count>=k)
                {
                    lol = lol - (items.Count);
                    resultList.Add(items[lol]);
                    foreach (var p in resultList)
                    {
                        Console.Write("{0} ", p);
                    }

                    Console.WriteLine(" ");
                    items.RemoveAt(lol);
                    foreach (var p in items)
                    {
                        Console.Write("{0} ", p);
                    }

                    Console.WriteLine(" ");
                    lol = lol - 1;
                }
                else if (items.Count < k)
                {
                    Console.WriteLine("insode else if");
                    Console.WriteLine(lol);
                    while (lol >= items.Count|| lol<0)
                    {
                        Console.WriteLine("inside while");
                        lol = lol - items.Count;
                        if (lol < 0)
                        {
                            Console.WriteLine("inside if lol<0");
                            lol = lol + items.Count;
                        }
                        Console.WriteLine(lol);
                        
                    }
                    resultList.Add(items[lol]);
                    items.RemoveAt(lol);
                    foreach (var p in resultList)
                    {
                        Console.Write("{0} ", p);
                    }

                    Console.WriteLine(" ");
                }
                else
                {
                    resultList.Add(items[lol]);
                    foreach (var p in resultList)
                    {
                        Console.Write("{0} ", p);
                    }

                    Console.WriteLine(" ");
                    items.RemoveAt(lol);
                    foreach (var p in items)
                    {
                        Console.Write("{0} ", p);
                    }

                    Console.WriteLine(" ");
                    lol = lol - 1;
                }

                lol += k;
            }
            return resultList;
        }
    }
}