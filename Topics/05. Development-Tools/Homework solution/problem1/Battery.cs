namespace MobilePhones
{
    using System;
    using log4net;

    public class Battery
    {
        private int hoursIdle;
        private int capacity;
        private static readonly ILog log = LogManager.GetLogger(typeof(Battery));

        public Battery() : this(null, 0, 0, 0)
        { 
        }

        public Battery(string model, int hoursIdleTime, int capacity, BatteryType batType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdleTime;
            this.Capacity = capacity;
            this.TypeOfBattery = batType;
            log4net.Config.XmlConfigurator.Configure();
        }

        public string Model { get; set; }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    log.Error("Negative value for battery hours idle provided");
                    throw new ArgumentOutOfRangeException("Hours idle time must be positive number");
                }

                this.hoursIdle = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    log.Error("Negative value for battery capacity provided");
                    throw new ArgumentOutOfRangeException("Capacity must be positive number");
                }

                this.capacity = value;
            }
        }

        public BatteryType TypeOfBattery { get; set; }

        public override string ToString()
        {
            return string.Format("Battery {0} {1} {2}mAh {3}h", this.Model, this.TypeOfBattery, this.Capacity, this.HoursIdle);
        }
    }
}
