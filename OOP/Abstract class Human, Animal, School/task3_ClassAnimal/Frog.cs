namespace task3_ClassAnimal
{
    public class Frog : Animal,ISound
    {
        public Frog(byte age, string name, Gender sex) : base(age, name, sex)
        {
        }

        public void Talk()
        {
            System.Console.WriteLine("Kvak, Kvakk...");
        }
    }
}
