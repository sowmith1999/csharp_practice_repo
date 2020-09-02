using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace practice
{
    class files
    {
        public static void FilesPractice()
        {
            var txtFile=new FileInfo(@"C:\Users\Sowmith Kunapaneni\Desktop\sampletext.txt");
            var txt = txtFile.ToString();
            Console.WriteLine(txt);
            var text= File.ReadAllText(@"C:\Users\Sowmith Kunapaneni\Desktop\sampletext.txt");
            Console.WriteLine("the text inside the file is"+text);
            var words = text.Split(" ");
            Console.WriteLine(words.Length);
            var maxLength = 0;
            var longestWord = "";
            foreach (var word in words)
            {
                var length = word.Length;
                if (length > maxLength)
                {
                    maxLength = length;
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);

        }
    }
}
