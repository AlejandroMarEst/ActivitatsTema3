using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class TabletopGame
    {
        public string Name { get; set; }

        public int Players { get; set; }

        public TabletopGame(string name, int players)
        {
            this.Players = players;
            this.Name = name;
        }
    }
}