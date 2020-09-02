using System;

namespace practice
{
    public class GoodvsEvil
    {
        enum GoodEnum
        {
            Hobbits=1,
            Men=2,
            Elves=3,
            Dwarves=3,
            Eagles=4,
            Wizards=10
        }
        public static string GoodVsEvil(string good, string evil)
        {
            var goodScore = Array.ConvertAll(good.Split(' '), int.Parse);
            var evilScore = Array.ConvertAll(evil.Split(' '), int.Parse);
            var goodTotal = 0;
            var evilTotal = 0;
            var goodArr = new[] {1, 2, 3, 3, 4, 10};
            var evilArr = new[] {1, 2, 2, 2, 3, 5, 10};
            for (var i = 0; i < goodArr.Length; i++)
            {
                goodTotal = goodTotal + goodArr[i] * goodScore[i];
            }
            for (var i = 0; i < goodArr.Length; i++)
            {
                evilTotal = evilTotal + evilArr[i] * evilScore[i];
            }

            if (goodTotal > evilTotal)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else if (goodTotal == evilTotal)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            else
            {
                return "Battle Result: No victor on this battle field";
            }
        }
    }
}