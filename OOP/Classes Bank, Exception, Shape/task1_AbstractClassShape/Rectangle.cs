namespace task1_AbstractClassShape
{
    public class Rectangle : Shape
    {
        #region Constructors
        
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        #endregion
        
        #region Methods
        
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    
        #endregion
    }
}
