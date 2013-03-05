/*
* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
* Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
* Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male.
* Each animal produces a specific sound. 
* Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace task3_ClassAnimal
{
    class TestApp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Kitten(1,"Nina"),
                new Tomcat(2,"Stoicho"),
                new Cat(5,"Mama Kotka",Gender.female),
                new Frog(1,"Kikerica",Gender.female),
                new Frog(2,"Jaborana",Gender.female),
                new Dog(5,"Balkan",Gender.male),
                new Dog(6,"Mustafa",Gender.male)
            };
            var avgAge = animals.Average(x => x.Age);
            Console.WriteLine(avgAge);

            List<Dog> dogs = new List<Dog>
            {
                new Dog(3,"Pacho Kardana",Gender.male),
                new Dog(7,"Gosho Karboratora",Gender.male),
                new Dog(9,"Yancho Djantata",Gender.male),
            };
            avgAge = dogs.Average(x => x.Age);
            Console.WriteLine(avgAge);

            List<Frog> frogs = new List<Frog>
            {
                new Frog(1,"Jaba Jaborana",Gender.male),
                new Frog(3,"Jaba Kikerica",Gender.male),
                new Frog(55,"Kermit",Gender.male)
            };
            avgAge = frogs.Average(x => x.Age);
            Console.WriteLine(avgAge);

            foreach (var frog in frogs)
            {
                frog.Talk();
            }
        }
    }
}
