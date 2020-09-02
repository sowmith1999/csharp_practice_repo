using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace practice.Exercises.strings_and_builder
{
    public class StringExercise
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen");
            var input = Console.ReadLine();
            var listNumbers=new List<int>();
            foreach (var n in input.Split("-"))
            {
                listNumbers.Add(Convert.ToInt32(n));
            }
            listNumbers.Sort();
            for (var i = 0; i < listNumbers.Count-1; i++)
            {
                if ((Convert.ToInt32(listNumbers[i]))+1 == Convert.ToInt32(listNumbers[i + 1]))
                {
                    continue;
                }

                Console.WriteLine("not consecutive");
                return;
            }

            Console.WriteLine("consecutive");

            //var holdNumber = numbers[0];
            //var count = 0;
            //foreach (var n in numbers)
            //{
            //    if (n == holdNumber)
            //    {
            //        count++;
            //        continue;
            //    }

            //    if (count > 1)
            //        return;

            //    if (n == holdNumber + 1)
            //    {
            //        holdNumber = n;
            //        continue;
            //    }

            //    Console.WriteLine("not consecutive");
            //    return;
            //}

            //Console.WriteLine("consecutive");
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("enter a few numbers separated by hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid input");
                return;
            }
            var numbersList=new List<int>();
            foreach(var n in input.Split('-'))
                numbersList.Add(Convert.ToInt32(n));
            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var n in numbersList)
            {
                if (!uniques.Contains(n))
                    uniques.Add(n);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            Console.WriteLine(includesDuplicates ? "Duplicates" : "no duplicates");
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>

        public static void Exercise3()
        {
            Console.WriteLine("enter a time value in the 24 hr time format(e.g. 19:00)");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid time");
                return;
            }
            
            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("invalid time");
                return;
            }

            try
            {
                var hrs = Convert.ToInt32(time[0]);
                var min = Convert.ToInt32(time[1]);
                if (hrs >= 0 && hrs <= 24)
                {
                    if (min >= 0 && min <= 60)
                    {
                        Console.WriteLine("okay");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("invalid time");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid time");
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public static void Exercise4()
        {
            Console.WriteLine("enter a few words separated by space");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid entry");
                return;
            }
            var word = input.Split(" ");
            var pascalVariable = new StringBuilder();
            foreach (var n in word)
            {
                var hold = char.ToUpper(n[0]) + n.Substring(1);
                pascalVariable.Append(hold);
            }

            Console.WriteLine(pascalVariable);
        }



        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>

        public static void Exercise5()
        {
            Console.WriteLine("enter an english word");
            var input = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid input");
                return;
            }
            var count = 0;

            var vowels = new[]{ 'a', 'i', 'e' ,'o','u'};
            foreach (var n in input)
            {
                if (vowels.Contains(n))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }


}
