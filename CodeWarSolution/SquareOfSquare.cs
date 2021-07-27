using System;

namespace CodeWarSolution
{
    
    /**
        Given an integral number, determine if it's a square number: 
        In mathematics, a square number or perfect square is an integer that is the square of an integer; 
        in other words, it is the product of some integer with itself. 
     **/
    
    public class SquareOfSquare
    {
        public static bool IsSquare(int n)
        {
            //Your code goes here!
            int sqrt = (int)Math.Sqrt(n);
            return  n == sqrt*sqrt;
        }
    }
}