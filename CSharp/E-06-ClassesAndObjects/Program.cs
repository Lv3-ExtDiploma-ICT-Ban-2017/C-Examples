using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace E_06_ClassesAndObjects
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //The `var` keyword allows auto-typing to cat
            //Lets create a list of animals, lists can be added to
            var animals = new List<Animal>();


            var cat1 = new Cat();
            cat1.Name = "Fluffy";
            cat1.Diet = new[] {"Bits", "Fish"};
            animals.Add(cat1);


            //Can also be written as
            var cat2 = new Cat {Name = "Devil", Diet = new[] {"Annoying children", "fish"}};
            animals.Add(cat2);

            //Meet rufus, the guard dog, he doesn't want to eat more memory than needed, so lets skip the variable
            animals.Add(new Dog() {Name = "Rufus", Diet = new[] {"Criminals"}});


            // ReSharper disable once CommentTypo
            //And print the shiz
            foreach (var animal in animals)
            {
                Console.WriteLine($"-------- {animal.Name} --------");
                Console.WriteLine("Type: " + animal.GetType().Name);
                Console.WriteLine("Name: " + animal.Name);
                Console.WriteLine("Diet:");
                foreach (var foodStuff in animal.Diet)
                {
                    Console.WriteLine(" - " + foodStuff);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Animal
    {
        public string Name;
        public string[] Diet;
    }

    internal class Cat : Animal
    {
    }

    internal class Dog : Animal
    {
    }
}