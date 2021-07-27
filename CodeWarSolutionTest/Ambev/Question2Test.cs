using CodeWarSolution.Ambev;
using NUnit.Framework;

namespace CodeWarSolutionTest.Ambev
{
    public class Question2Test
    {
        [Test]
        public void IsOk()
        {
            Assert.AreEqual(true, Question2.Execute("xy-abc-a", 3));      
        }
    }
}