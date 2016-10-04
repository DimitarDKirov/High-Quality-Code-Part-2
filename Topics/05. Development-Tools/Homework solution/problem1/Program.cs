namespace MobilePhones
{
    using System;
    using log4net;
    using log4net.Config;

    public class GSMbegin
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(GSM));

        public static void Main()
        {

            Battery bl5c = new Battery("BL-5C", 300, 33, BatteryType.NiMH);
            GSM nokia1100 = new GSM("1100", "NOKIA", 100, "Ivan Ivanov", bl5c, 1.3f);
            Console.WriteLine(nokia1100);

            GSM galayA5 = new GSM("Galaxy A5", "Samsung", 779.90f, "Penka Petkova", new Battery("2300mAh integrated", 100, 2300, BatteryType.LiPol), 4.5f);
            Console.WriteLine(galayA5);

            Battery iPhoneBat = new Battery("iPhone bat", 200, 2000, BatteryType.LiIon);
            GSM iPhone = new GSM("iPhone4S", "Apple", 1000f, "Happy Iphone Owner", iPhoneBat, 3.5f);
            Console.WriteLine(iPhone);
            GSM lgA390 = new GSM("A390-Dual SIM", "LG", 115, "Kirov", new Battery("1700 mAh", 800, 1700, BatteryType.LiIon), 2.1f);
            Call call1 = new Call("10.10.14", "10:05", "088812346", 18);
            Call cal2 = new Call(DateTime.Now, "0899999999", 150);
            Call cal3 = new Call();
            lgA390.AddCall(call1);
            lgA390.AddCall(cal2);
            lgA390.AddCall(cal3);
            Console.WriteLine(lgA390);
            Console.WriteLine(lgA390.CalcCallsPrice(0.37f));

            //new GSM(" ", " ");
            //call1.CallTime = null;
            //bl5c.Capacity = -1;
            //iPhone.DisplaySize = -1;            
        }
    }
}