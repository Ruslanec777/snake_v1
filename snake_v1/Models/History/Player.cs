using System;

namespace snake_v1.Models.History
{
    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int HiScoreThisPlayer { get; set; } = default;

        public Player(string name, int score)
        {
            Name = name;

            if (score > HiScoreThisPlayer)
            {
                HiScoreThisPlayer = score;
            }
        }

        public int CompareTo(Player player)
        {
            return HiScoreThisPlayer.CompareTo(player.HiScoreThisPlayer);
        }


    }
}
