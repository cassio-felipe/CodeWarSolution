using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class FindMissingLetterTest
    {
        [Test]
        public void IsMissingLetter()
        {
            Assert.AreEqual('e', FindMissingLetter.FindMissing(new [] { 'a','b','c','d','f' }));
            Assert.AreEqual('P', FindMissingLetter.FindMissing(new [] { 'O','Q','R','S' }));
        }
    }
}