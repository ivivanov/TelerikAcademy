using System;

namespace task8_Events
{
    public class CountDownTimer
    {
        //Delegate EventHandler
        public delegate void TimeChangedEventHandler(object sender, TimeChangedEventArgs e);

        //Event
        public event TimeChangedEventHandler TimeChanged;

        //Event Trigger
        protected void OnTimeChanged()
        {
            if (TimeChanged != null)
            {
                TimeChanged(this, new TimeChangedEventArgs(this.Seconds));        
            }
        }

        //Fields
        private int interval;
        private int seconds;

        //Construnctors
        public CountDownTimer(int seconds, int interval)
        {
            this.seconds = seconds;
            this.interval = interval;
        }

        //Properties
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                this.interval = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                this.seconds = value;
                OnTimeChanged();
            }
        }

        //Methods
        public void StartCountDownTimer()
        {
            while (Seconds > 0)
            {
                Seconds--;
                System.Threading.Thread.Sleep(Interval * 1000);
            }
        }


    }
}
