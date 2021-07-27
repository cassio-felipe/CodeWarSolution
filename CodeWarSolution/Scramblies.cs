namespace CodeWarSolution
{
    
    /**
     * Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2,
     * otherwise returns false.
     */
    
    public class Scramblies
    {
        public static object Scramble(string str1, string str2)
        {
            var texto = str1;
            foreach (var c in str2)
            {
                if (texto.Contains(c))
                {
                    texto = texto.Remove(texto.IndexOf(c), 1);
                }
                else
                    return false;
            }
            return true;
        }
    }
}