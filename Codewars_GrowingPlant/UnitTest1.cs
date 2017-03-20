using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Codewars_GrowingPlant
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstDay_fulfill()
        {
            Assert.AreEqual(1, new Kata().GrowingPlant(10, 9, 4));
        }
    }

    public class Kata
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            throw new NotImplementedException();
        }
    }
}