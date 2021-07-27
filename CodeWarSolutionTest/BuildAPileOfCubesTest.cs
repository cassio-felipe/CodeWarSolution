using CodeWarSolution;
using NUnit.Framework;

namespace CodeWarSolutionTest
{
    public class BuildAPileOfCubesTest
    {
        [Test]
        public void Test1() {
            Assert.AreEqual(2022, BuildAPileOfCubes.findNb(4183059834009));
        }
        [Test]
        public void Test2() {
            Assert.AreEqual(-1, BuildAPileOfCubes.findNb(24723578342962));
        }
        [Test]
        public void Test3() {
            Assert.AreEqual(4824, BuildAPileOfCubes.findNb(135440716410000));
        }
        [Test]
        public void Test4() {
            Assert.AreEqual(3568, BuildAPileOfCubes.findNb(40539911473216));
        }
        [Test]
        public void Test5() {
            Assert.AreEqual(3218, BuildAPileOfCubes.findNb(26825883955641));
        }
        [Test]
        public void Test6() {
            Assert.AreEqual(-1, BuildAPileOfCubes.findNb(41364076483082));
        }
        [Test]
        public void Test7() {
            Assert.AreEqual(2485, BuildAPileOfCubes.findNb(9541025211025));
        }
        [Test]
        public void Test8() {
            Assert.AreEqual(-1, BuildAPileOfCubes.findNb(112668204662785));
        }
        [Test]
        public void Test9() {
            Assert.AreEqual(4788, BuildAPileOfCubes.findNb(131443152397956));
        }
        [Test]
        public void Test10() {
            Assert.AreEqual(-1, BuildAPileOfCubes.findNb(108806345136785));
        }
    }
}