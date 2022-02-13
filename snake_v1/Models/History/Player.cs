using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.History
{
    public class Player
    {
        public string Name { get; set; }
        public int HiScoreThisPlayer { get; set; } = default;

        public Player(string name, int score)
        {
            Name = name;

            if (score>HiScoreThisPlayer)
            {
                HiScoreThisPlayer = score;
            }           
        }



    }
}
