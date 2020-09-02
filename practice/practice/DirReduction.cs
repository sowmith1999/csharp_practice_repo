using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    public class DirReduction
    {

        public static string[] dirReduc(String[] arr)
        {
            var dirlist = new List<string>();
            foreach (var s in arr) dirlist.Add(s.ToLower());
            for (var i = 1; i <= dirlist.Count - 1; i++)
            {
                var current = dirlist[i];
                if ((dirlist[i-1] == "north" && current == "south") || (current == "north" && dirlist[i-1] == "south"))
                {
                    dirlist.RemoveAt(i);
                    dirlist.RemoveAt(i - 1);
                    i = 0;
                    continue;
                }
                if ((dirlist[i-1] == "west" && current == "east") || (current == "west" && dirlist[i-1] == "east"))
                {
                    dirlist.RemoveAt(i);
                    dirlist.RemoveAt(i - 1);
                    i = 0;
                    continue;
                }

            }

            for (var i = 0; i <= dirlist.Count - 1; i++)
            {
                dirlist[i] = dirlist[i].ToUpper();
            }
            return dirlist.ToArray();
        }
    }
}