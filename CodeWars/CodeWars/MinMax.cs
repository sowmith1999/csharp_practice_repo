using System.Linq;

namespace CodeWars
{
    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            var highest = lst[0];
            var lowest = lst[0];
            highest = lst.Max();
            lowest = lst.Min();
            foreach (var number in lst)
            {
                if (number > highest)
                {
                    highest = number;
                }
                if (number < lowest)
                { lowest = number; }
            }
            var returnarray=new int[] { lowest,highest};
            return returnarray;
        }
    }
}