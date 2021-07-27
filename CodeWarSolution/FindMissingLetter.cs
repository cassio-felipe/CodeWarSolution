using System;
using System.Linq;

namespace CodeWarSolution
{
    public class FindMissingLetter
    {
        public static char FindMissing(char[] array)
        {
            for (int i = 0; i < array.Length -1 ; i++)
            {
                if ((array[i] + 1) != array[i + 1])
                    return (char) (array[i] + 1);
            }
            return '\0';
        }
    }
    
    /*
     * (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x))
     * Range cria uma colecao de 25 itens a partir do valor de array[0]
     * ai ele pega o primeiro em que nao exista dentro do array 
     */
}

