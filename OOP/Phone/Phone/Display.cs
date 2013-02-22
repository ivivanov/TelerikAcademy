
namespace MobilePhone
{
    public class Display
    {
        #region Fields

        private double size;
        private int colors;

        #endregion

        #region Constructors

        public Display()
            : this(0, 0)
        {
        }

        public Display(double size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }

        #endregion

        #region Properties

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            string result = "Size: " + Size + @"""" + " Colors: " + Colors;
            return result;
        }

        #endregion
    }
}
