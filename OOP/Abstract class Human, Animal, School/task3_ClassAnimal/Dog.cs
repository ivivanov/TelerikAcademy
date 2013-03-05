using System;

namespace task3_ClassAnimal
{
    public class Dog : Animal, ISound
    {
        public Dog(byte age, string name, Gender sex) : base(age, name, sex)
        {
        }
        
        public void Talk()
        {
            Console.WriteLine("Bau bauuuuu...");
        }
    }
}
