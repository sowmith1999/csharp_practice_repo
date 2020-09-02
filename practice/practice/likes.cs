using System;

namespace practice
{
    public static class likes
    {
        public static string Likes(string[] name)
        {
            var returnstring = "";
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1)
            {
                return name[0]+" likes this";
            }
            else if (name.Length == 2)
            {
                returnstring = name[0] + ' ' + "and" + ' ' + name[1]+ " like this";
            }
            else if(name.Length ==3)
            {
                returnstring = name[0] + ',' + ' ' + name[1] + ' ' + "and" +' '+name[2]+ " others like this";
            }
            else
            {
                returnstring = name[0] + ',' + ' ' + name[1] + ' ' + "and" + ' ' + Convert.ToString(name.Length-2)+ " like this";
            }
            return returnstring;
        }
        //public static string Likes(string[] names)
        //{
        //    switch (names.Length)
        //    {
        //        case 0: return "no one likes this"; // :(
        //        case 1: return $"{names[0]} likes this";
        //        case 2: return $"{names[0]} and {names[1]} like this";
        //        case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
        //        default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        //    }
        //}
    }
}