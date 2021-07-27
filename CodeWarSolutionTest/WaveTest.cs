using System.Collections.Generic;
using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class WaveTest
    {
        [Test]
        public void IsWave()
        {
            Wave kata = new Wave();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, kata.wave("hello"), "it should return '"+result+"'");
            
            result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, kata.wave("two words"), "it should return '" + result + "'");
        }
    }
}