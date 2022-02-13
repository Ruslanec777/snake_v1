using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models.History
{
    public class GameHistory
    {
        private string _fileName;

        List<Player> players { get; set; }
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
            Player player = SearshPlayer(name);

            if (player == null)
            {
                CreatePlaerRec(new Player(name, score));

                return;
            }
            else
            {
                ReSaveHiScore( player, score);
            }

        }

        private void ReSaveHiScore(Player player, int score)
        {
            if (player.HiScoreThisPlayer<score)
            {
                player.HiScoreThisPlayer = score;

            }
            else
            {
                return;
            }
        }

        public void SaveHiScorePlayer(Player player)
        {

            CreatePlaerRec(player);
        }

        private void CreatePlaerRec(Player player)
        {
            throw new NotImplementedException();
        }

        private Player SearshPlayer(string name)
        {
            //Player tempPlayer=
            return players.Where(x => x.Name == name).FirstOrDefault();
        }

        //private string[] SearchFileToSave(string fileName)
        //{
        //    string currentPath = AppDomain.CurrentDomain.BaseDirectory.ToString();

        //    string[] files = Directory.GetFiles(currentPath);

        //    //foreach (var file in files)
        //    //{
        //    //    if (File.GetAttributes().ToString == fileName)
        //    //    {
        //    //        _currentFile = file;
        //    //    }
        //    //}

        //    return files;
        //}
    }
}
