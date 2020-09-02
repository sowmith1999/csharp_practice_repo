using System.Threading;

namespace CodeWars
{
    class OddInt
    {
        public static int find_it(int[] seq)
        {
            var count = 0;
            for (var i = 0; i < seq.Length; i++)
            {
                foreach (var number in seq)
                {
                    if (seq[i] == number)
                    { 
                        count++;
                    }
                }

                if (count % 2 == 1)
                {
                    return seq[i];
                }
            }

            return 0;
        }

    }
}