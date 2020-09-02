using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Algorithms_ToolBox_Week4
{
    class BinarySearch
    {
        public static void BinarySearchArray()
        {
            var k = Console.ReadLine().Split(' ');
            var m = Console.ReadLine().Split(' ');
            var numberOfElements = long.Parse(k[0]);
            var inputArray = new long[numberOfElements];
            for(var i=0;i<numberOfElements;i++)
            {
                inputArray[i]= long.Parse(k[i+1]);
            }
            var elementsToSearch = long.Parse(m[0]);
            var searchArray = new long[elementsToSearch];
            for (var i = 0; i < elementsToSearch; i++)
            {
                searchArray[i] = long.Parse(m[i + 1]);
            }
            for(var i=1;i<=elementsToSearch;i++)
            {
                var hold = inputArray;
                var tosearch = searchArray[i];
                while (hold.Length > 2)
                {
                    int middle = hold.Length / 2;
                    if(hold[middle]==tosearch)
                    {
                        searchArray[i] = middle;
                    }
                    else if(hold[middle]>tosearch)
                    {
                        Array.Copy(hold, hold, middle);
                    }
                    else if(hold[middle] > tosearch)
                    {
                        Array.Copy(hold,middle+1,hold,0,hold.Length-middle);
                    }
                }
            }

           

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch.BinarySearchArray();
        }
    }
}
