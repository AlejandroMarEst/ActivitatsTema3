using System;

namespace ActivitatsTema3
{
    public class Team
    {
        // Formado por un conjunto de jugadores (Lista)
        public string TeamName { get; set; }
        public Team(string name)
        {
            TeamName = name;
        }
    }
}
