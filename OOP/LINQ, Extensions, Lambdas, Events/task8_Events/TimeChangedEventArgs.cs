using System;

namespace task8_Events
{
    public class TimeChangedEventArgs : EventArgs
    {
        public int SecondsChanged { get; private set; }

        public TimeChangedEventArgs(int seconds)
        {
            this.SecondsChanged = seconds;
        }
    }
}
