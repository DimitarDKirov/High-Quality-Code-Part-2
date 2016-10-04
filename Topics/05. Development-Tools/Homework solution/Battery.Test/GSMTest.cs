using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhones;

namespace MobilePhonesTest
{
    [TestClass]
    public class GsmTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_shouldThrowIfModelIsNull()
        {
            GSM phone=new GSM(null, "Nokia");  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfModelIsWhiteSpace()
        {
            GSM phone = new GSM("  ", "LG");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfManufacturerIsNull()
        {
            GSM phone = new GSM("1100", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfManufacturerIsWhiteSpace()
        {
            GSM phone = new GSM("1100", "   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GSM_ShouldThrowIfPriceIsNegative()
        {
            GSM phone = new GSM("Samsung", "Galaxy 4", -1, null, null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GSM_ShouldThrowIfDisplaySizeIsNegative()
        {
            GSM phone = new GSM("Apple", "iPhone6");
            phone.DisplaySize = -1;
        }

        [TestMethod]
        public void GSMCalls_ShouldStoreZeroCallsAndCalculatePrice0()
        {
            Battery battery=new Battery("BL-5C", 200, 1700, BatteryType.LiIon);
            GSM phone = new GSM("Samsung", "Galaxy 4", 550.34f, "Dimitar", battery, 5.0f);
            phone.AddCall(new Call());
            var result = phone.CalcCallsPrice(1.0f);
            float expected = 0.0f;
            Assert.AreEqual(expected, result, "Zero call should have price 0");
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Battery battery = new Battery("BL-5C", 200, 1700, BatteryType.LiIon);
            GSM phone = new GSM("Nokia", "1100", 100f, "Dimitar", battery, 1.5f);
            float callPrice = 2f;
            float expected = 0f;
            CallsGenerator calls=new CallsGenerator();
            for (int i = 0; i < calls.Calls.Length ; i++)
            {
                phone.AddCall(calls.Calls[i]);
                expected += calls.Calls[i].CallDuration / 60f;
            }

            expected *= callPrice;
            float result = phone.CalcCallsPrice(callPrice);
            Assert.AreEqual(expected, result, "All calls price should be correct "+expected);
        }
   
    }
}
