using System;
using System.Linq;

namespace practice
{
    public class ROt13Cipher
    {
        public static string Rot13(string message)
        {
            var charArray = message.ToCharArray();
            for (var c=0;c<charArray.Length;c++)
            {
                var asciiValue = Convert.ToInt32(charArray[c]);

                if (asciiValue<=122 && asciiValue>=97)
                {
                    
                    if (asciiValue <= 109)
                    {
                        charArray[c] = Convert.ToChar(asciiValue + 13);
                    }
                    else
                    {
                        charArray[c] = Convert.ToChar(asciiValue - 13);
                    }
                }
                if (asciiValue <= 90 && asciiValue >=65)
                {

                    if (asciiValue <= 77)
                    {
                        charArray[c] = Convert.ToChar(asciiValue + 13);
                    }
                    else
                    {
                        charArray[c] = Convert.ToChar(asciiValue - 13);
                    }
                }

            }
            return new string(charArray);
        }
    }
}