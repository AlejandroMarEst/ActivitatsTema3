using System;

namespace ActivitatsTema3
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Player(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
