using System.Collections.Generic;

namespace practice
{
    public class ArthimeticProg
    {
        public static int FindMissing(List<int> list)
        {
            var difference = list[1] - list[0];
            for (var i = 0; i < list.Count; i++)
            {
                var cdifference = list[i + 1] - list[i];
                if (difference > cdifference)
                {
                    return list[0] + cdifference;
                }

                if (difference < cdifference)
                {
                    return list[i] + difference;
                }


            }
            return 0;
        }
    }
}