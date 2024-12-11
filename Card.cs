using System;
using System.Xml.Linq;

namespace ActivitatsTema3
{
    public class Card : TabletopGame
    {
        public string Type { get; set; }

        public int Value { get; set; }
        public Card(string type, int value, string name, int players) : base(name, players)
        {
            Type = type;
            Value = value;
        }
    }
}