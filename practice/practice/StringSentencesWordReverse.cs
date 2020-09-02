using System;

namespace practice
{
    public class StringSentencesWordReverse
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            var outputString = "";
            for (var i=0;i<=words.Length-1;i++)
            {
                if (words[i].Length >= 5)
                {
                    outputString = outputString + reversal(words[i]);
                }
                else
                {
                    outputString = outputString + words[i];
                }

                if (i < words.Length)
                {
                    outputString = outputString + ' ';
                }
            }

            return outputString;
        }
        //public static string Reverse(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}
        public static string reversal(string word)
        {
            char[] chararray=word.ToCharArray();
            var reversedword = "";
            for (var i=chararray.Length-1;i>=0; i--)
            {
                reversedword = reversedword + chararray[i];
            }


            return reversedword;
        }
    }
}