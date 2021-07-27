using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarSolution.Ambev
{
    public class Question2
    {
        public static IEnumerable<String> Execute(string texto, int part)
        {

            //jeito 1
            
            //   for (var i = 0; i < s.Length; i += part)
           // {
           //     Console.WriteLine(s.Substring(i, Math.Min(part, s.Length-i)));
           // }
            
         /**  
           //jeito 2
           int index = 0;
           var teste = from c in s
               let itemIndex = index++
               group c by itemIndex / part
               into g
               select new string(g.ToArray());
**/
         //jeito 3
           int index = 0;
           var teste2 = from c in texto
               let itemIndex = index++
               group c by itemIndex / 3
               into agrupador
               select agrupador.ToArray();
           
           foreach (var t in teste2)
           {
               Console.WriteLine(t);
           }
           
            return null;
        }
    }
}