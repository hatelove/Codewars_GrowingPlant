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

        [TestMethod]
        public void twoDays_fulfill()
        {
            ShouleWaitDays(2, 10, 1, 19);
        }
    }

    public class Kata
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            var result = 1;
            if (upSpeed >= desiredHeight)
            {
                return result;
            }
            else
            {
                result++;
                var h1 = GetGrowingHeightPerDay(upSpeed, downSpeed);
                if (h1 + upSpeed >= desiredHeight)
                {
                    return result;
                }

                throw new NotImplementedException();
            }
        }

        private static int GetGrowingHeightPerDay(int upSpeed, int downSpeed)
        {
            var h1 = upSpeed - downSpeed;
            return h1;
        }
    }
}