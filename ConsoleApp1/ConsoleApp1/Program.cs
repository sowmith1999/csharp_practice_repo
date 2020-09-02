using System;

namespace ConsoleApp1
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(int x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Math.Round(9.48));
            int date = 20;
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName} {date}";
            //Console.WriteLine(name);
            //string myString = "Heello";
            //Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
            // Full name
            //string name = "John Doe";

            //// Location of the letter D
            //int charPos = name.IndexOf("D");
            //Console.WriteLine(charPos);
            //// Get last name
            //string lastName = name.Substring(charPos,1);

            ////Print the result
            //Console.WriteLine(lastName);
            //bool isCSharpFun = true;
            //bool isFishTasty = false;
            //Console.WriteLine("whether Csharp is fun or not" + isCSharpFun);   // Outputs True
            //Console.WriteLine(isFishTasty);   // Outputs False
            //MyMethod();
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4, 6.0);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
