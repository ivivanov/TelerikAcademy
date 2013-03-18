namespace task2_ClassBank.Customers
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return "Company Customer";
        }
    }
}
