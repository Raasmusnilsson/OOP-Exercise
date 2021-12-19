using System;

namespace ConsoleApp4
{
    internal partial class Program
    {
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
                Console.WriteLine("Voff!!"); 
            }
        }
    }
}