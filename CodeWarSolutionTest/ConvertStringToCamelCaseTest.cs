using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class ConvertStringToCamelCaseTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"));
            Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"));
        }
    }
}