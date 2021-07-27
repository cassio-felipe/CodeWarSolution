using System;
using System.Linq;

namespace CodeWarSolution
{
    /**
     * Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
     */
    
    public class YourOrderPlease
    {
        public static string Order(string words)
        {
            var listWords = words.Split(" ").ToList();

            return string.Join(" ", listWords.OrderBy(x => x.SingleOrDefault(char.IsDigit)));
            
            //words.Split(" ").OrderBy(x => x.SingleOrDefault(char.IsDigit)))
        }
    }
}