using System;

namespace ConsoleApp4
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Dog-1", 1);
            Animal dog2 = new Dog("Dog-2", 2);

            Shelter shelter = new Shelter();

            shelter.AddAnimal(dog);
            shelter.AddAnimal(dog2);

            shelter.DeleteAnimal("Dog-1");
            shelter.DeleteAnimal(2);

            shelter.AddAnimal(dog);
            shelter.AddAnimal(dog2);

            shelter.UpdateAnimal(dog, "New name");

            Console.WriteLine(shelter.GetAnimal(1).GetName());

            var myshelter = shelter.GetAnimals();

            foreach (Animal animal in myshelter)
            {
                animal.MakeSound();
            }
        }
    }
}