using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace snake_v1.Models.History
{
    public class GameHistory
    {
        private string _fileName;

        List<Player> players
        {
            get
            {
                players.Sort();
                return players;
            }
            set { }
        }

        public GameHistory(string fileName)
        {
            _fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + fileName;

            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }
        }

        public void SaveHiScorePlayer(string name, int score)
        {
            var ps = new PlayerSearh (name);

            Player player = players.Find(ps.Compare);

            if (player == null)
            {
                CreatePlaerRec(new Player(name, score));

                return;
            }
            else
            {
                ReSaveHiScore(player, score);
            }

        }

        private void ReSaveHiScore(Player player, int score)
        {
            if (player.HiScoreThisPlayer < score)
            {
                PlayerSearh ps = new(player);

                players.Find(ps.Compare).HiScoreThisPlayer = score;

            }
            else
            {
                return;
            }
        }

        private void CreatePlaerRec(Player player)
        {
           players.Add(player);
        }

        //private Player SearshPlayer(string name)
        //{
        //    //Player tempPlayer=
        //    return players.Where(x => x.Name == name).FirstOrDefault();
        //}

        /// <summary>
        /// класс для создания предиката
        /// </summary>
        private class PlayerSearh
        {
            public string Name { get; set; }

            public PlayerSearh(Player player)
            {
                Name = player.Name;
            }

            public PlayerSearh(String name)
            {
                Name =name;
            }

            public bool Compare(Player player)
            {
                return Name == (player.Name);
            }
        }
    }
}
