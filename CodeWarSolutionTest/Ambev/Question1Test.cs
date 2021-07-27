using System;
using CodeWarSolution.Ambev;
using NUnit.Framework;

namespace CodeWarSolutionTest.Ambev
{
    public class Question1Test
    {
        [Test]
        public void IsOk()
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            UnloadingTime[] unloadingTimes = new UnloadingTime[] 
            {
                new UnloadingTime(DateTime.Parse("3/4/2019 19:00", format), DateTime.Parse("3/4/2019 20:30", format)),
                new UnloadingTime(DateTime.Parse("3/4/2019 22:10", format), DateTime.Parse("3/4/2019 22:30", format)),
                new UnloadingTime(DateTime.Parse("3/4/2019 20:30", format), DateTime.Parse("3/4/2019 22:00", format))
            };

            Assert.AreEqual(true, Question1.Execute(unloadingTimes));
        }
    }
}