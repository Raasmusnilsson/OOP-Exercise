using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
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
        public abstract class Animal
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public Animal(string name, int id)
            {
                Name = name;
                Id = id;
            }
            internal string GetName()
            {
                return Name;
            }
            internal void MakeSound()
            {
                Console.WriteLine("Voff!"); 
            }
        }
        public class Dog : Animal
        {
            public Dog(string name, int id) : base(name, id) { }
        }
        public class Shelter
        {
            public List<Animal> Dogs = new();
            public Shelter() { }
            public void AddAnimal(Animal animal)
            {
                Dogs.Add(animal);
            }
            public void DeleteAnimal(string name)
            {
                foreach (Animal animal in Dogs)
                {
                    if (animal.Name == name)
                    {
                        Dogs.Remove(animal);
                        break;
                    }
                }
            }
            public void DeleteAnimal(int id)
            {
                foreach (Animal animal in Dogs)
                {
                    if (animal.Id == id)
                    {
                        Dogs.Remove(animal);
                        break;
                    }
                }
            }
            public void UpdateAnimal(Animal dog, string newName)
            {
                dog.Name = newName;
            }
            public Animal GetAnimal(int id)
            {   
               var dog = Dogs.Find(dog => dog.Id == id);
               
                return dog;
            }
            public List<Animal> GetAnimals()
            {
                return Dogs;
            }
        }
    }
}