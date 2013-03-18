using System;

namespace task1_AbstractClassShape
{
    public class Circle : Shape
    {
        #region Constructors
        
        public Circle(int radius)
        {
            this.Width = radius;
            this.Height = radius;
        }
        
        #endregion
        
        #region Methods
        
        public override double CalculateSurface()
        {
            return Math.PI * (Height * Height);
        }
    
        #endregion
    }
}
