using System.Collections.Generic;

namespace ConsoleApp4
{
    internal partial class Program
    {
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