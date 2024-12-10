using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Card
    {
        public string Type { get; set; }

        public int Value { get; set; }

        public Card(string type, int value)
        {
            this.Type = type;
            this.Value = value;
        }
    }
}