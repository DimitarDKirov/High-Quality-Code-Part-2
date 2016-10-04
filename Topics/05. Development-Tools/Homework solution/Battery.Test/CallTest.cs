using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhones;

namespace MobilePhonesTest
{
    [TestClass]
    public class CallTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateCall_NullDateShouldThrow()
        {
            Call call = new Call(null, "10:02", null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateCall_NullTimeShouldThrow()
        {
            Call call = new Call("12.08.2015", null, null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateCall_InvalidStringForDateShouldThrow()
        {
            Call call = new Call("12082015", "10:02", null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateCall_InvalidStringForTimeShouldThrow()
        {
            Call call = new Call("12082015", "10-02", null, 0);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectString()
        {
            DateTime callDate = new DateTime(2010, 12, 31, 23, 59, 59);
            string date = callDate.ToShortDateString();
            Call call = new Call(callDate, "088888888", 120);
            string expected = "Call " + date + " 23:59:59 to: 088888888 duration 2:00";
            string result = call.ToString();
            Assert.AreEqual(expected, result, "The output string should contain call date, time, number, duration");
        }

    }
}
