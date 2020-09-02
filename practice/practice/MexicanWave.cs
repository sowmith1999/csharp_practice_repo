using System;
using System.Collections.Generic;

namespace practice
{
    public class MexicanWave
    {
        public static List<string> wave(string str)
        {
            var wavelist=new List<string>();
            for (var i=0;i<str.Length;i++)
            {
                if (str[i] == ' ')
                    continue;
                else
                    wavelist.Add(Convert.ToString(str.Substring(0,i) +char.ToUpper(str[i]))+str.Substring(i+1));
            }
            return wavelist;
        }
    }
}