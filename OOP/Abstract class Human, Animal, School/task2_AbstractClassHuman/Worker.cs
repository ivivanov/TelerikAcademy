namespace task2_AbstractClassHuman
{
    public class Worker : Human
    {
        #region Fields
        
        private decimal weeklySalary;
        private byte workHoursPerDay;
        
        #endregion
        
        #region Constructors
        
        public Worker(string firsName, string lastName, decimal weeklySalary, byte workHoursPerDay) : base(firsName,lastName)
        {
            this.weeklySalary = weeklySalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        
        #endregion
        
        #region Properties
        
        public decimal WeeklySalary
        {
            get
            {
                return this.weeklySalary;
            }
            set
            {
                this.weeklySalary = value;
            }
        }
        
        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public decimal MoneyPerHour()
        {
            return weeklySalary / (5 * WorkHoursPerDay);
        }
    
        #endregion
    }
}
