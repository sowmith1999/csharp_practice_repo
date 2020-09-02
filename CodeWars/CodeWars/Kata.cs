//using System;

//namespace CodeWars
//{
//    public class Endswith
//    {
//        public static bool Solution(string str, string ending)
//        {
//            //if strings are abcde and de
//            var difference = str.Length - ending.Length;//difference = 3
//            var count = 0;
//            if (str.Length < ending.Length)
//                return false;
//            for (var i = difference; i <str.Length; i++)
//            {
//                if (str[i] == ending[i - difference])
//                {
//                   count++;
//                }
//            }

//            if (count == ending.Length)
//            {
//                return true;
//            }
//            return false;
//            var highest = lst[0];
//            var lowest = lst[0];
//            foreach (var number in lst)
//            {
//                if (number > highest)
//                    highest = number;
//                if (number < lowest)
//                    lowest = number;
//            }

//        }
//    }
//}