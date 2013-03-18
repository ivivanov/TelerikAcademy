namespace task1_AbstractClassShape
{
    public class Triangle : Shape
    {
        #region Constructors
        
        public Triangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        #endregion
        
        #region Methods
        
        public override double CalculateSurface()
        {
            return Width * Height / (double)2;
        }
    
        #endregion
    }
}
