using System;
using System.Collections.Generic;
using System.IO;

namespace snake_v1.Models.History
{
    public class GameHistory
    {
        private readonly string _fileName;

        private List<Player> _players;
        List<Player> Players
        {
            get
            {
                //_players.Sort();
               // _players.

                return _players;
            }
            set => _players = value;
        }

        public GameHistory(string fileName)
        {
            _fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + fileName;

            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }

            Players = new();
        }

        public void SaveHiScorePlayer(string name, int score)
        {
            var ps = new PlayerSearh(name);

            Player player = Players.Find(ps.Compare);

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

                Players.Find(ps.Compare).HiScoreThisPlayer = score;

            }
            else
            {
                return;
            }
        }

        private void CreatePlaerRec(Player player)
        {
            Players.Add(player);
        }

        private void WriteToFile(String path, List<Player> players)
        {
            using ( StreamWriter streamWriter=new StreamWriter(path, false))
            {
                streamWriter.WriteLine(players);
            }



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
                Name = name;
            }

            public bool Compare(Player player)
            {
                return Name == (player.Name);
            }
        }
    }
}
