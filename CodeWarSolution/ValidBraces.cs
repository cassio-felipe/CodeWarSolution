using System.Collections.Generic;

namespace CodeWarSolution
{
    public class ValidBraces
    {
        public static bool IsValidBraces(string braces)
        {
            var st = new Stack<char>();
            
            foreach (var c in braces)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(c);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }    
            }
            return st.Count == 0;
        }
        
        /**
         * public static bool validBraces(String braces) {
            var current = "";
            while (braces.Any() && current != braces)
            {
                current = braces;
                braces = braces.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return !braces.Any();
        }
         */
    }
}