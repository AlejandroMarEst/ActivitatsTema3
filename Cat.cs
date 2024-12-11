using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Cat
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Breed { set; get; }
        public string FavFood { set; get; }
        public Cat(string name, int age, string breed, string favFood)
        {
            Name = name;
            Age = age;
            Breed = breed;
            FavFood = favFood;
        }

        public void Meowing()
        {
            Console.WriteLine("Meeeooowww");
        }
        public void Play()
        {
            Console.WriteLine("Meow Meow!!");
        }
        public void Wash()
        {
            Console.WriteLine("Meow Meooow :(");
        }
        public void Eat()
        {
            Console.WriteLine("Nom Nom Nom");
        }
        public void Hunt()
        {
            Console.WriteLine("Meoooowwww hisssssss");
        }
    }
}