namespace practice
{
    public class PascalCase
    {
        //Kata.ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"

        //Kata.ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"
        public static string ToCamelCase(string str)
        {
            var finalString = "";
            finalString =finalString+ str[0];

            for (var k=1;k<str.Length;k++)
            {
                
                if (str[k] == '_' || str[k]=='-')
                {
                    finalString = finalString + char.ToUpper(str[k+1]);
                    k++;
                }
                else
                {
                    finalString = finalString + char.ToLower(str[k]);
                }
            }
            return finalString;
        }
    }
}