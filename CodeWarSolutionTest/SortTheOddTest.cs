using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class SortTheOddTest
    {
        [Test]
        public void ValidaSortArray()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, SortTheOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, SortTheOdd.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, SortTheOdd.SortArray(new int[] { }));
        }
    }
}