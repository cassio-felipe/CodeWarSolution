namespace CodeWarSolution
{
    public class ConvertStringToCamelCase
    {
        /*
         * Complete the method/function so that it converts dash/underscore delimited words into camel casing.
         * The first word within the output should be capitalized only if the original word was capitalized
         * (known as Upper Camel Case, also often referred to as Pascal case).
         */
        
        public static string ToCamelCase(string str)
        {

            var words = str.Split('-','_');
            var result = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                result += words[i].Substring(0, 1).ToUpper() +
                          words[i].Substring(1);
            }
            return result;
        }
        
        /*
         * Cleaver Solution
         * return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
         */
    }
    
}