using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace snake_v1.Models.History
{

    public class DataStorage
    {
        private string _pathToStorage;
        private string _fileName;

        private Game _game;

        public DataStorage(Game game)
        {
            _game = game;

            _pathToStorage = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), _game.dirToStorage);
            _fileName = Path.Combine(_pathToStorage, _game.fileName) ;

            if (!Directory.Exists(_pathToStorage))
            {
                Directory.CreateDirectory(_pathToStorage);
            }
            //_fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + _fileName;

            if (!File.Exists(_fileName))
            {
                File.Create(_fileName).Dispose();
            }
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _fileName), false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(_game.MenuLeaderBoard.Players));
            }
        }

        public void Load()
        {
            if (File.Exists(_fileName))
            {
                using (StreamReader sr = new StreamReader(_fileName))
                {
                    _game.MenuLeaderBoard.Players = JsonConvert.DeserializeObject<List<Player>>(sr.ReadToEnd());
                    if (_game.MenuLeaderBoard.Players == null)
                    {
                        _game.MenuLeaderBoard.Players = new List<Player>();
                    }
                }
            }
            else
            {
                _game.MenuLeaderBoard.Players = new List<Player>();
            }
        }
    }
}
