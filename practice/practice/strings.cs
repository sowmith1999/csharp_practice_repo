using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class strings
    {
        static public void String()
        {
//            var firstName = "sowmith";
//            var secondName = "kunapaneni";
//            var myName = firstName + " " + secondName;
//            Console.WriteLine(myName);
//            var myFullName = string.Format("my name is {0} {1}", firstName, secondName);
//            Console.WriteLine(myFullName);

//            var names = new string[3]{"somwith","kunapaneni","sowmith" };
//            var formattedNames = string.Join(",", names);
//            Console.WriteLine(formattedNames);

//            //verbatim is the usage of @ infront of a text to avoid escape charachters
//            var text = @"the man in the field
//is a great guy  but the file paths are bad
//c:/folder1/folder2
//c:/folder3/folder4";
//            Console.WriteLine(text);
            var fullName = "sowmith kunapanneni ";
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.ToUpper());
            //Index
            var index = fullName.IndexOf(' ');
            //substring based on index range
            Console.WriteLine("first name:"+fullName.Substring(0,index));
            Console.WriteLine("last name:"+fullName.Substring(index+1));
            //substring using split
            var names = fullName.Split(" ");
            Console.WriteLine("first name:"+names[0]);
            Console.WriteLine("last name:"+ names[1]);
            //using replace method,replace method cannot change the original string it creates a new string
            Console.WriteLine(fullName.Replace("sow", "SOWbadalalala"));

            if (string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 67.93f;
            Console.WriteLine(price.ToString("C0"));




        }
    }
}
