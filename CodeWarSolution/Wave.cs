using System;
using System.Collections.Generic;

namespace CodeWarSolution
{
    public class Wave
    {
        public List<string> wave(string str)
        {
            var result = new List<string> { };
            for (int i = 0; i < str.Length; i++)
            {
                var item = str.ToCharArray();

                if (item[i] != ' ')
                {
                    item[i] = Char.ToUpper(item[i]); 
                    result.Add(new string(item));
                }
            }
            return result;
        }
    }
}