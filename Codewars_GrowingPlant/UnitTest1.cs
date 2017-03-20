using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var currentHeight = 0;
            var days = 1;
            while (currentHeight + upSpeed < desiredHeight)
            {
                days++;
                currentHeight += GetGrowingHeightPerDay(upSpeed, downSpeed);
            }

            return days;
        }

        private static int GetGrowingHeightPerDay(int upSpeed, int downSpeed)
        {
            return upSpeed - downSpeed;
        }
    }
}