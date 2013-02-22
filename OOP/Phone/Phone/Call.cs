using System;

namespace MobilePhone
{
    public class Call
    {
        #region Fields

        private string date;
        private string time;
        private string dailedPhone;
        private int callDuration;

        //Assume the price per minute is fixed.
        private double pricePerMinute = 0.37;

        #endregion

        #region Constructors

        public Call(string dailedPhone)
            : this(dailedPhone, 0)
        { }

        public Call(string dailedPhone, int duration)
        {
            DateTime now = DateTime.Now;
            this.date = now.Month + "/" + now.Day;
            this.time = now.Hour + ":" + now.Minute;
            this.dailedPhone = dailedPhone;
            this.callDuration = duration;
        }

        #endregion

        #region Properties

        public string Date
        {
            get 
            {
                return this.date;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
        }
        public string DailedPhone
        {
            get
            {
                return this.dailedPhone;
            }
        }
        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                this.callDuration = value;
            }
        }
        public double PricePerMinute
        {
            get
            {
                return this.pricePerMinute;
            }
            private set
            {
                this.pricePerMinute = value;
            }
        }

        #endregion

        #region Methods



        #endregion
    }
}
