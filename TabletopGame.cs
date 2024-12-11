using System;

namespace ActivitatsTema3
{
    public class TabletopGame
    {
        public string Name { get; set; }

        public int Players { get; set; }

        public TabletopGame(string name, int players)
        {
            Players = players;
            Name = name;
        }
    }
}
