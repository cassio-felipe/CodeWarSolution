using System.Collections.Generic;
using System.Linq;

namespace CodeWarSolution
{
    
    public class SortTheOdd
    {
        /*
          You will be given an array of numbers. You have to sort the odd numbers in
          ascending order while leaving the even numbers at their original positions.
        */

        public static int[] SortArray(int[] array)
        {
            List<int> listaRetorno = new List<int>();
            var arrayImpar = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    listaRetorno.Add(array[i]);
                else
                {
                    listaRetorno.Add(arrayImpar[j]);
                    j++;
                }
            }
            return listaRetorno.ToArray();
        }

    }

}