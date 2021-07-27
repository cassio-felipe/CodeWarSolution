using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class ValidBracesTest
    {
        [Test]
        public void IsValidBraces()
        {
            Assert.AreEqual(true, ValidBraces.IsValidBraces( "()" ));    
            Assert.AreEqual(true, ValidBraces.IsValidBraces( "(){}[]"));    
            Assert.AreEqual(true, ValidBraces.IsValidBraces( "([{}])"));    
            Assert.AreEqual(false, ValidBraces.IsValidBraces( "(}"));    
            Assert.AreEqual(false, ValidBraces.IsValidBraces( "[(])"));    
            Assert.AreEqual(false, ValidBraces.IsValidBraces( "[({})](]"));    
        }
    }
}
