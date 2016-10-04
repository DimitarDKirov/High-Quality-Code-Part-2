namespace MobilePhonesTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MobilePhones;

    [TestClass]
    public class BatteryTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateBattery_ExpectHoursIdleToThrowIfNegative()
        {
            Battery bat = new Battery(null, -2, 0, BatteryType.LiIon);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateBattery_ExpectNegativeCapacityTalkToThrow()
        {
            Battery bat = new Battery(null, 0, -1, BatteryType.LiIon);
        }

        [TestMethod]
        public void BatteryToString_ExpectToBeCorrect()
        {
            Battery battery = new Battery("BL-5C", 170, 1700, BatteryType.LiPol);
            string result = battery.ToString();
            string expected = "Battery BL-5C LiPol 1700mAh 170h";
            Assert.AreEqual(expected, result, "The output string should contain all values divided with interval");
        }
    }
}
