namespace task2_ClassBank.Customers
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return "Individual Customer";
        }
    }
}
