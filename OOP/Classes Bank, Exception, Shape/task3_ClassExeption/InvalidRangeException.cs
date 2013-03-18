using System;

namespace task3_ClassExeption
{
    public class InvalidRangeException<T> : ApplicationException
    {
        #region Fields
        
        private T start;
        private T end;
        private const string message = "Outsite range exception";
        
        #endregion
        
        #region Constructors
        
        public InvalidRangeException(string msg, T start, T end, Exception innerException) : base(msg,innerException)
        {
            this.start = start;
            this.end = end;
        }
        
        public InvalidRangeException(string msg, T start, T end) : this(msg, start, end, null)
        {
        }
        
        public InvalidRangeException(T start, T end) : this(message,start,end,null)
        {
        }
        
        #endregion
        
        #region Properties
        
        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }
        
        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }


        
        #endregion
    
        #region Methods

        #endregion
    }
}
