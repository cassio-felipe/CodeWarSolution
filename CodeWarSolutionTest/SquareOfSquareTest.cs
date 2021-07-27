using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class SquareOfSquareTest
    {
        [Test]
        public void ValidaIsSquare()
        {
            Assert.AreEqual(false, SquareOfSquare.IsSquare(-1),"negative numbers aren't square numbers");
            Assert.AreEqual(true, SquareOfSquare.IsSquare(0),"0 is a square number (0 * 0)");
            Assert.AreEqual(false, SquareOfSquare.IsSquare(3),"3 isn't a square number");
            Assert.AreEqual(true, SquareOfSquare.IsSquare(4),"4 is a square number (2 * 2)");
            Assert.AreEqual(true, SquareOfSquare.IsSquare(25),"25 is a square number (5 * 5)");
            Assert.AreEqual(false, SquareOfSquare.IsSquare(26),"26 isn't a square number");    
        }
    }
}