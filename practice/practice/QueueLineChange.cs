namespace practice
{
    public class QueueLineChange
    {
        public static string Tickets(int[] peopleInLine)
        {
            var availableChange = new int[] {0,0,0};
            for (var i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                {
                    availableChange[0] += 1;
                }
                else if (peopleInLine[i] == 50)
                {
                    if (availableChange[0] > 0)
                    {
                        availableChange[0] -= 1;
                        availableChange[1] += 1;
                    }
                    else
                    {
                        return "NO";
                    }
                }
                else
                {
                    if (availableChange[0] > 0 && availableChange[1] > 0)
                    {
                        availableChange[0] -= 1;
                        availableChange[1] -= 1;
                        availableChange[2] += 1;
                    }
                    else if (availableChange[0] >= 3)
                    {
                        availableChange[0] -= 3;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }
}