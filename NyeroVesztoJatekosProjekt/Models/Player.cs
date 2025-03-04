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
        public int Score { get; private set; }
        public int WinCount { get; private set; } = 0;
        public int LossCount { get; private set; } = 0;
        public string IsWinningString => Name + " " + (Lost ? "nevű játékos kiesett." : (WinCount > LossCount ? "nyerő" : "vesztő") + " játékos.");
        public bool Lost => Score < 0;

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

        public void ChangeScore(int point)
        {
            if(Lost)
            {
                throw new Exception($"{Name} nevű játékos már kiesett a játékból!");
            }
            Score += point;
            if(point > 0)
            {
                WinCount++;
            }
            else if(point < 0)
            {
                LossCount++;
            }
        }

        public string CompareWith(Player player2)
        {
            if(this.Lost)
            {
                throw new Exception($"{this.Name} nevű játékos már kiesett a játékból!");
            }
            else if (player2.Lost)
            {
                throw new Exception($"{player2.Name} nevű játékos már kiesett a játékból!");
            }
            else if (this.Lost && player2.Lost)
            {
                throw new Exception($"{this.Name} és {player2.Name} nevű játékosok már kiesett a játékból!");
            }

            if (this.Score > player2.Score)
            {
                //return $"{this.Name} a győztes pontszám alapján!";
                return $"{this.Name} --> {this.Score} pont";
            }
            else if(this.Score < player2.Score)
            {
                //return $"{player2.Name} a győztes pontszám alapján!";
                return $"{player2.Name} --> {player2.Score} pont";
            }
            else
            {
                return $"{this.Name} és {player2.Name} pontszáma egyezik, pontszámuk: {this.Score}!";
            }
        }



        public override string ToString()
        {
            return $"{Name} ({Email}) -> {Score} pont";
        }

    }
}
