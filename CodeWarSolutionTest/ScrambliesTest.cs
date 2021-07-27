using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class ScrambliesTest
    {
        [Test]
        public void IsValidScramble()
        {
            Assert.AreEqual(true, Scramblies.Scramble("rkqodlw","world"));
            Assert.AreEqual(true, Scramblies.Scramble("cedewaraaossoqqyt","codewars"));
            Assert.AreEqual(false, Scramblies.Scramble("katas","steak"));
            Assert.AreEqual(false, Scramblies.Scramble("scriptjavx","javascript"));
            Assert.AreEqual(true, Scramblies.Scramble("scriptingjava","javascript"));
            Assert.AreEqual(true, Scramblies.Scramble("scriptsjava","javascripts"));
            Assert.AreEqual(false, Scramblies.Scramble("javscripts","javascript"));
            Assert.AreEqual(true, Scramblies.Scramble("aabbcamaomsccdd","commas"));
            Assert.AreEqual(true, Scramblies.Scramble("commas","commas"));
            Assert.AreEqual(true, Scramblies.Scramble("sammoc","commas"));
        }
    }
}