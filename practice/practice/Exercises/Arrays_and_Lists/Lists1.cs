using System;
using System.Collections.Generic;
using System.Linq;

namespace practice.Exercises.Arrays_and_Lists
{
    public class Lists1
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public static void Exercise1()
        {
            var names = new List<string>();
            var count = 0;

            Console.WriteLine("Enter a name and hit enter");
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
                count++;
            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }


        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Enter your Name");
            var input = Console.ReadLine();
            var lengthOfInput = input.Length;

            var name = new char[lengthOfInput];

            for (var i = 0; i < lengthOfInput; i++)
            {
                name[i] = input[lengthOfInput - 1 - i];
            }
            //in c# as the strings are immutable to convert a array of char to string one needs to use new string which takes the char array as an argument
            var reverseName = new string(name);
            foreach (var n in reverseName)
                Console.Write(n);
        }


        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        public static void Exercise3()
        {
            //Console.WriteLine("enter 5 digits which have to be sorted with , or space between them");
            //var input=Console.ReadLine();
            //var numbers = input.Split(',');
            //var numberArray = new int[numbers.Length];
            //for (var i=numbers.Length;i>=0;i--)
            //{
            //    numberArray[i] = Convert.ToInt32(numbers[i]);
            //}
            //Array.Sort(numberArray);
            //foreach (var n in numberArray)
            //{
            //    Console.WriteLine(n);
            //}
            var numbers = new List<Int32>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("enter a number");
               var number = Convert.ToInt32(Console.ReadLine());
               if (numbers.Contains(number))
               {
                   Console.WriteLine("you've already entered this number");
                   continue;
               }
               numbers.Add(number);
            }
            numbers.Sort();
            foreach(var n in numbers)
                Console.WriteLine(n);
        }


        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public static void Exercise4()
        {
            var numbers=new List<Int32>();
            while (true)
            {
                Console.WriteLine("enter a number or type quit");
                var input = Console.ReadLine();
                if (input.ToLower()=="quit")
                {
                    break;
                }
                if (numbers.Contains(Convert.ToInt32(input)))
                {
                    continue;
                }
                numbers.Add(Convert.ToInt32(input));
            }
            foreach(var n in numbers)
                Console.WriteLine(" {0} ", n);
        }



        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        public static void Exercise5()
        {
            Console.WriteLine("Enter a list of comma separated numbers, should be more than 5 numbers ");
            var input = Console.ReadLine();
            var numbers=new List<int>();
            var number = input.Split(',');
            if (number.Length < 5)
            {
                Console.WriteLine("Invalid List, Please retry");
                return;
            }
            foreach(var i in number)
                numbers.Add(Convert.ToInt32(i));
            //for (var i = 0; i <= number.Length; i++);
            //{
            //    Console.WriteLine(number[i]);
            //    numbers.Add(Convert.ToInt32(number[i]));
            //}
            while (numbers.Count > 3)
            {
                var i = 0;
                var count = 0;
                foreach (var n in numbers)
                {
                    if (n > numbers[i])
                    {
                        count++;
                    }
                }
                if(count>3)
                    numbers.Remove(numbers[i]);

            }
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
       
    }
}
