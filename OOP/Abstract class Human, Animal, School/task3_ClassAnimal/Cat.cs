using System;

namespace task3_ClassAnimal
{
    public class Cat : Animal, ISound
    {
        public Cat(byte age, string name, Gender sex) : base(age,name,sex)
        {
        }
        
        public void Talk()
        {
            Console.WriteLine("Miauuu, miuauuu");
        }
    }
}
