using System;
using System.Collections.Generic;
using practice.Exercises.Arrays_and_Lists;
using practice.math;
using practice.Exercises.ControlFlow;
using practice.Exercises.strings_and_builder;

namespace practice
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegAirMail = 2,
        Express = 3

    }


    class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduction()
        {
            Console.WriteLine("my name is" + " " + FirstName + " " + LastName);
        }
    }

    class Solution
    {

        static public void RunIt()
        {
            var studentList = new List<student>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(var i=0;i<=n;i++)
            {
                var stud = new student();
                stud.Id= Convert.ToInt32(Console.ReadLine());

            }

            // Write your code to create a list of students, take input and call showmax function
        }
        public void showmax(List<student> stud, string course)
        {
            // Write your code to find the maximum of the students mark and print the result

        }
    }
    class Program
    {
        public static void ListTrail()
        {
            var listy=new List<int>(){1,2,3,4,5,6,7};
            Console.WriteLine(listy[1]);
            var listListy=new List<List<int>>(){new List<int>(){1,2,3,4,5,6}, new List<int>(){234,456,344}};
            Console.WriteLine(listListy[1].Count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("hey bro wassup");
            //var a = 'b';
            //var b = 'c';
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Person john = new Person();
            //john.FirstName = "john";
            //john.LastName = "statham";
            //john.Introduction();
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Arrays.printArray();
            //strings.String();
            // var method = ShippingMethod.Express;
            // Console.WriteLine((int)method);
            //// Console.WriteLine(method.ToString());
            // Console.WriteLine(method);

            // var methodID = 3;
            // Console.WriteLine((ShippingMethod)methodID);
            //Loops.Exercise1();
            //Loops.Exercise2();
            //Loops.Exercise3();
            //Loops.Exercise4();
            //Loops.Exercise5();

            //Arrays.Array1();
            //Lists.List1();
            //Lists1.Exercise1();
            //Lists1.Exercise3();
            //Lists1.Exercise4();
            //Lists1.Exercise5();
            //StringExercise.Exercise1();
            //StringExercise.Exercise2();
            //StringExercise.Exercise3();
            //StringExercise.Exercise4();
            //StringExercise.Exercise5();
            //files.FilesPractice();
            //Console.WriteLine(PascalCase.ToCamelCase("the-stealth-warrior"));
            //Console.WriteLine(ArthimeticProg.FindMissing(new List<int> { 1, 2, 4, 5, 6 }));
            //ListTrail();
            //var humor=listylist.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
            //foreach (var word in humor)
            //{
            //    Console.WriteLine(word);
            //}
            //var a = new[] { 1, 2, 5, 6, 34, 3, 4, 5 };
            //var b = new[] { 1, 2, 5, 6, 34, 3, 4, 5 };
            //Array.Sort(a, b);
            //foreach (var n in b)
            //{
            //    Console.WriteLine(n);
            //}
            //int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            //int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            //Console.WriteLine(ArrayComparision.comp(a,b));
            //var str = "sowmith";
            ////var reverse =new String(str.Reverse().ToArray());
            //Console.WriteLine(reverse);
            //Console.WriteLine(reverse.GetType());
            //StringSentencesWordReverse.reversal("sowmith");
            //var person = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            //var damn=TwoSumArrayTuple.TwoSum(new[] { 2, 2, 3 }, 4);
            //foreach (var num in damn)
            //{
            //    Console.WriteLine(num);
            //}
            //var arr = new int[] {1, 2, 3, 4, 5, 6, 7};
            //var list = arr.ToList();
            //foreach(var n in list)
            //    Console.WriteLine(n);
            //var arey=DirReduction.dirReduc(new[] {"NORTH", "SOUTH","SOUTH","WEST","EAST", "NORTH","SOUTH","WEST", "SOUTH", "EAST", "WEST", "NORTH", "WEST"});
            //foreach(var i in arey)
            //    Console.WriteLine(i);
            //var good = "1 2 3 4 5 6 7 8";
            //var goodScore = good.Split(' ');
            //goodScore=c
            //var goodScore=Array.ConvertAll(good.Split(' '), Int32.Parse);
            //foreach (var i in goodScore)
            //{
            //    Console.WriteLine(i);
            //}
            //var exList=new List<int>(){1,2,3,4,5,6,7};
            //var n = 7;
            //var r = 4;
            //var combinations = 35;
            //for (var i = 0; i <= combinations; i++)
            //{

            //}
            //const int k = 4;
            //var n = new[] { "1", "2", "3", "4", "5","6","7" };

            //Console.Write("n: ");
            //foreach (var item in n)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("k: {0}", k);
            //Console.WriteLine();

            //foreach (IEnumerable<string> i in Combination.Combinations(n, k))
            //    Console.WriteLine(string.Join(" ", i));
            //foreach(var i in MexicanWave.wave("hello"))
            //    Console.WriteLine(i);
            //var lala = "hello";
            //Console.WriteLine(lala.Substring(5));
            //int[][] array =
            //{
            //    new[] { 1, 2, 3, 9 },
            //    new[] { 4, 5, 6, 4 },
            //    new[] { 7, 8, 9, 1 },
            //    new[] { 1, 2, 3, 4 }
            //};
            //int[][] array =
            //{
            //    new[]{1,2,3,4},
            //    new []{5,6,7,8},
            //    new []{9,10,11,12},
            //    new[]{13,14,15,16}
            //};
            //int[][] array =
            //{
            //    new[]{1,2,3,4,5},
            //    new []{6,7,8,9,10},
            //    new []{11,12,13,14,15},
            //    new[]{16,17,18,19,20},
            //    new []{21,22,23,24,25}
            //};
            //int[][] array =
            //{
            //    new[]{1,2,3,4,5,6},
            //    new []{7,8,9,10,11,12},
            //    new []{13,14,15,16,17,18},
            //    new[]{19,20,21,22,23,24},
            //    new []{25,26,27,28,29,30},
            //    new []{31,32,33,34,35,36}
            //};
            //var lala =SnailSolution.Snail(array);
            //foreach(var i in lala)
            //    Console.WriteLine(i);
            //int R = 6;
            //int C = 6;
            //int[,] a = { { 1, 2, 3, 4, 5, 6 },
            //    { 7, 8, 9, 10, 11, 12 },
            //    { 13, 14, 15, 16, 17, 18 },
            //    {19,20,21,22,23,24},
            //    {25,26,27,28,29,30},
            //    {31,32,33,34,35,36}

            //};
            //SnailSolution.spiralPrint(R, C, a);
            //Console.WriteLine(Convert.ToChar(99));
            //Console.WriteLine(ROt13Cipher.Rot13("Test"));
            //var c = new[] {'c','d','e' };
            //Console.WriteLine(c);

            //var lola=JosephusPermute.JosephusPermutation(new List<object>() { "C", "o", "d", "e", "W", "a", "r", "s" }, 4);
            //foreach (var i in lola)
            //{
            //    Console.WriteLine(i);
            //}
            ////Console.WriteLine(NextSmallNumber.NextSmaller(1027));
            //var n = 923994872938;
            //var charArray = n.ToString().ToCharArray();
            //foreach (var c in charArray)
            //{
            //    Console.WriteLine(c);
            //}
            //var intArray = new int[charArray.Length];
            //for (var i = 0; i < charArray.Length; i++)
            //{
            //    intArray[i] = Convert.ToInt32(charArray[i]);
            //}

            //foreach (var i in intArray)
            //{
            //    Console.WriteLine(i);
            //}
            // var array = new[] { 1, 2, 3, 6, 7, 3, -1, -4 };
            // RangeExtraction.Extract(array);
        }
    }
}
