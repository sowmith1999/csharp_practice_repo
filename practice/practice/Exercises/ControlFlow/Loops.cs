using System;

namespace practice.Exercises.ControlFlow
{
    public class Loops
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        public static void Exercise1()
        {
            var count = 0;
            for (var i=1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }


        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>

        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number");
                var Hold= Console.ReadLine();
                if (Hold.ToLower() == "ok")
                {
                    break;
                }
                sum = sum + Convert.ToInt32(Hold);

            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>

        public static void Exercise3()
        {
            Console.WriteLine("enter a number");
            var factorial = 1;
            var Input = Console.ReadLine();
            for(var i=Convert.ToInt32(Input);i>0;i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }


        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>
        public static void Exercise4()
        {
            var number= new Random().Next(1, 10);
            Console.WriteLine("guess the number between 1 to 10, you've got 4 chances");
            for(var i=1; i<=4; i++)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("you won");
                    return;
                }

            }
            Console.WriteLine("You Lost");

        }
        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        public static void Exercise5()
        {
            Console.WriteLine("enter a series of numbers seperated by ',' and the program will return the maximum vakues of them");
            var numbers = Console.ReadLine();
            //if (numbers[0] ==',')
            //{
            //    Console.WriteLine("okay");
            //}
            int number = 0;
            for (var i = numbers.Length; i >= 1; i--)
            {
                if ((numbers[i - 1] == ','))
                {
                    continue;
                }
                else
                {
                    if (numbers[i - 1] > number)
                    {
                        number = numbers[i - 1];
                    }
                }
            }
            Console.WriteLine(number-48);

        }
    }
}
