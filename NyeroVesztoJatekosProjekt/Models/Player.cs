using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyeroVesztoJatekosProjekt.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Email { get; }
        public int StartingScore { get; }
        public int Score { get; set; }
        public int WinCount { get; set; } = 0;
        public int LossCount { get; set; } = 0;

        public Player(string name, string email, int startingScore)
        {
            if(startingScore < 0)
            {
                throw new Exception("Nem kezdhet a játékos negatív pontszámmal!");
            }
            Name = name;
            Email = email;
            StartingScore = startingScore;
            Score = startingScore;
        }

        public override string ToString()
        {
            return $"{Name} ({Email}) -> {Score} pont";
        }

    }
}
