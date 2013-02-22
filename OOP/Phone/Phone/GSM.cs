using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        #region Fields

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4s = new GSM("4s", "Apple", 399.99m, "Mr. Jobs", new Battery("Nice", 5, 1.3, BatteryType.LiIon), new Display(3.5, 16000000));
        private List<Call> callHistory;
       
        #endregion

        #region Constructors

        public GSM()
            : this(null, null, 0, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, params Call[] calls)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            if (calls == null)
            {
                this.callHistory = new List<Call>();
            }
            else
            {
                this.callHistory = new List<Call>(calls);
            }
        }

        #endregion

        #region Properties

        public string Model
        {
            get
            {
                return this.model ?? "Unknown";
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer ?? "Unknown";
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner ?? "Unknown";
            }
            set
            {
                this.owner = value;
            }
        }
        public string Battery
        {
            get
            {
                if (this.battery == null)
                {
                    return "Unknown";
                }
                return this.battery.ToString();
            }
        }
        public string Display
        {
            get
            {
                if (this.display == null)
                {
                    return "Unknown";
                }
                return this.display.ToString();
            }
        }
        public string IPhone4s
        {
            get
            {
                return iPhone4s.ToString();
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            string result = "Model: " + Model + "\nManufacturer: " + Manufacturer + "\nPrice: " + Price + "\nOwner: " + Owner + "\nBattery: " + Battery + "\nDisplay: " + Display;
            return result;
        }
        
        public void AddCalltoHistory(Call newCall)
        {
            if (newCall == null)
            {
                throw new ArgumentNullException(@"""null"" calls are not allowed!");
            }
            this.callHistory.Add(newCall);
        }
        
        public int DeleteCallFromHistory(Call call)
        {
            if (call == null)
            {
                throw new ArgumentNullException(@"Trying to delete ""null"" call.");
            }
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Date == call.Date &&
                    callHistory[i].Time == call.Time &&
                    callHistory[i].DailedPhone == call.DailedPhone)
                {
                    callHistory.RemoveAt(i);
                    return 1;
                }
            }
            return -1;
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCallLog()
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("Empty log!");
            }
            else
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine("Date: " + call.Date + " " + call.Time + " Dailed number: " + call.DailedPhone + " Call duration: " + call.CallDuration);
                }
            }
        }

        public void CalculatePrice()
        {
            double totalCost = 0;
            double totalDuration = 0;
            foreach (Call call in callHistory)
            {
                totalDuration += call.CallDuration;
                totalCost += (call.CallDuration / 60.0) * call.PricePerMinute;
            }
            Console.WriteLine("All calls duration: {0:F2} minutes, total cost: {1:F2} bgn", totalDuration / 60, totalCost);
        }
        #endregion
    }
}
