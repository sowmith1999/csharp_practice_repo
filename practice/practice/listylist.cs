using System.Collections.Generic;

namespace practice
{
    public class listylist
    {

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var outList=new List<string>();
            foreach (var person in data)
            {
                    if (person[0] >= 55 && person[1] > 7)
                    {
                        outList.Add("Senior");
                    }
                    else
                    {
                        outList.Add("Open");
                    }
            }

            return outList;
        }
    }
}