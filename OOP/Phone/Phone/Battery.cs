
namespace MobilePhone
{
    public enum BatteryType
    {
        Unknown,
        LiIon,
        NiMH,
        NiCd
    };

    public class Battery
    {
        #region Fields

        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        #endregion

        #region Constructors

        public Battery()
            : this(null, 0, 0, BatteryType.Unknown)
        {
        }
        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        #endregion

        #region Properties

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type.ToString();
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            string result = "Model: " + Model + " HoursIdle: " + HoursIdle + " HoursTalk: " + HoursTalk + " Type: " + Type;
            return result;
        }

        #endregion
    }
}
