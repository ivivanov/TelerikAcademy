namespace task1_AbstractClassShape
{
    public abstract class Shape
    {
        #region Fields
        
        private int width;
        private int height;
        
        #endregion
        
        #region Properties
        
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public abstract double CalculateSurface();
    
        #endregion
    }
}
