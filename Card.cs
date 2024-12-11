using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Card : TabletopGame
    {
        public string Type { get; set; }

        public int Value { get; set; }

        public Card(string type, int value, string name, int players) : base(name,players)
        {
            Type = type;
            Value = value;
            Name = name;
            Players = players;
        }
    }
}