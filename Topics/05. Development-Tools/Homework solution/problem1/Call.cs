namespace MobilePhones
{
    using System;
    using log4net;

    public class Call
    {
        private DateTime callDateTime;
        private static readonly ILog log = LogManager.GetLogger(typeof(Call));

        public Call() : this(DateTime.MinValue, string.Empty, 0)
        { 
        }

        public Call(DateTime callDateTime, string number, ushort callDuration)
        {
            this.callDateTime = callDateTime;
            this.PhoneNumber = number;
            this.CallDuration = callDuration;
            log4net.Config.XmlConfigurator.Configure();
        }

        public Call(string callDate, string callTime, string number, ushort callDuration)
        {
            this.CallDate = callDate;
            this.CallTime = callTime;
            this.PhoneNumber = number;
            this.CallDuration = callDuration;
        }

        public string CallDate
        {
            get
            {
                return this.callDateTime.ToShortDateString();
            }

            set
            {
                try
                {
                    this.callDateTime = DateTime.Parse(value, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                }
                catch (Exception ex)
                {
                    log.Error("Incorect format for date provided");
                    throw new FormatException("Date is not in correct format");
                }
            }
        }

        public string CallTime
        {
            get
            {
                return this.callDateTime.ToLongTimeString();
            }

            set
            {
                TimeSpan time;
                try
                {
                    time = TimeSpan.Parse(value);
                }
                catch (Exception ex)
                {
                    log.Error("Incorect format for time provided");
                    throw new FormatException("Time format is not correct");
                }

                this.callDateTime = callDateTime.Add(time);
            }
        }

        public string PhoneNumber { get; set; }

        public ushort CallDuration { get; set; }

        public override string ToString()
        {
            return string.Format("Call {0} {1} to: {2} duration {3}:{4:00}", this.CallDate, this.CallTime, this.PhoneNumber, this.CallDuration / 60, this.CallDuration % 60);
        }
    }
}
