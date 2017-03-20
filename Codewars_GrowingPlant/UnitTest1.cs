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
            ShouleWaitDays(1, 10, 9, 4);
        }

        private static void ShouleWaitDays(int expected, int upSpeed, int downSpeed, int desiredHeight)
        {
            Assert.AreEqual(expected, new Kata().GrowingPlant(upSpeed, downSpeed, desiredHeight));
        }
    }

    public class Kata
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            if (upSpeed >= desiredHeight)
            {
                return 1;
            }

            throw new NotImplementedException();
        }
    }
}