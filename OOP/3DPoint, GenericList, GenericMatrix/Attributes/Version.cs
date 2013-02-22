[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct |
                       System.AttributeTargets.Enum |
                       System.AttributeTargets.Method)]

public class Version : System.Attribute
{
    private double ver;

    public Version(double ver)
    {
        this.ver = ver;
    }

    public double Ver
    {
        get
        {
            return this.ver;
        }
    }
}
