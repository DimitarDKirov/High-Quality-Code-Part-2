namespace MobilePhones
{
    using System;
    using System.Collections.Generic;
    using log4net;

    /// <summary>
    /// Stores information about GSM mobile phone and calls
    /// </summary>
    public class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private float displaySize;
        private List<Call> callHistory;
        private static readonly ILog Log = LogManager.GetLogger(typeof(GSM));

        /// <summary>
        /// Creates instance of GSM
        /// </summary>
        /// <param name="model">Model of the mobile phone. Obligatory</param>
        /// <param name="manufacturer">Brand of the mobile phone. Obligatory</param>
        /// <param name="price">Price of the mobile phone</param>
        /// <param name="owner">Owner's name</param>
        /// <param name="battery">Battery instance representing the battery installed in the phone</param>
        /// <param name="displaySize">The size of the display in inches</param>
        public GSM(string model, string manufacturer, float price, string owner, Battery battery, float displaySize)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneOwner = owner;
            this.BatteryData = battery;
            this.DisplaySize = displaySize;
            this.callHistory = new List<Call>();
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// Creates simplified instance of GSM with obligatory parameters
        /// </summary>
        /// <param name="model">Model of the mobile phone. Obligatory</param>
        /// <param name="manufacturer">Brand of the mobile phone. Obligatory</param>
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0.0f, null, null, 0.0f)
        {
        }

        /// <summary>
        /// Model of the mobile phone.
        /// </summary>
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Log.Error("Null or whitespace value for GSM model provided");
                    throw new ArgumentNullException("Model must be specified");
                }

                this.model = value;
            }
        }

        /// <summary>
        /// Brand of the mobile phone
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Log.Error("Null or whispace value for GSM manufacturer");
                    throw new ArgumentNullException("Manufacturer must be specified");
                }

                this.manufacturer = value;
            }
        }

        /// <summary>
        /// Price of the mobile phone. Positive number
        /// </summary>
        public float Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0.0)
                {
                    Log.Error("Negative value for GSM price");
                    throw new ArgumentOutOfRangeException("Price must be positive number or 0");
                }

                this.price = value;
            }
        }

        /// <summary>
        /// Size of the display in inches. Positive number
        /// </summary>
        public float DisplaySize
        {
            get
            {
                return this.displaySize;
            }

            set
            {
                if (value < 0)
                {
                    Log.Error("Negative value for GSM display size");
                    throw new ArgumentOutOfRangeException("Display size can not be negative number");
                }

                this.displaySize = value;
            }
        }

        /// <summary>
        /// Owner's name
        /// </summary>
        public string PhoneOwner { get; set; }

        public Battery BatteryData { get; set; }

        /// <summary>
        /// Provides data of the mobile phone as a string
        /// </summary>
        /// <returns>Phone's data</returns>
        public override string ToString()
        {
            string phoneData = string.Format("{1} {0} {2}\" Price: {3:c}\tOwner: {4}\n{5}\n", this.model, this.manufacturer, this.DisplaySize, this.price, this.PhoneOwner, this.BatteryData.ToString());
            return phoneData;
        }

        /// <summary>
        /// Adds a call to the list of calls for this phone
        /// </summary>
        /// <param name="call">The call to be added to the repository</param>
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
            Log.Info("new call " + call.ToString());
        }

        /// <summary>
        /// Clears the list of calls for this phone
        /// </summary>
        public void ClearCallHistory()
        {
            Log.Info("Call history cleared");
            this.callHistory.Clear();
        }

        /// <summary>
        /// Calculates the price of all calls for this phone by given price
        /// </summary>
        /// <param name="pricePerMinute">Price per minute for a call</param>
        /// <returns>Total price of all calls</returns>
        public float CalcCallsPrice(float pricePerMinute)
        {
            float result = 0.0f;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                result += pricePerMinute * this.callHistory[i].CallDuration / 60;
            }

            return result;
        }
    }
}
