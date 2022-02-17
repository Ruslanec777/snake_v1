using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace snake_v1.Models.History
{

    public class DataStorage
    {
        private string _pathToStorage;
        private const string _fileName = "save.txt";

        public DataStorage(string pathToStorage)
        {
            _pathToStorage = pathToStorage;
            if (!Directory.Exists(_pathToStorage))
            {
                Directory.CreateDirectory(_pathToStorage);
            }
        }

        public void Save(List<Player> players)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _fileName), false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(players));
            }
        }


        private void Load(out List<Player> players)
        {
            string st = Path.Combine(_pathToStorage, _fileName);

            if (File.Exists(st))
            {
                using (StreamReader sr = new StreamReader(Path.Combine(_pathToStorage, _fileName)))
                {
                    players = JsonConvert.DeserializeObject<List<Player>>(sr.ReadToEnd());
                    if (players == null)
                    {
                        players = new List<Player>();
                    }
                }
            }
            else
            {
                players = new List<Player>();
            }
        }


    }
    // class DataStorage
    //{
    //    private string _directoryName;
    //    private const string _fileName ="save.txt";

    //    public DataStorage()
    //    {
    //        _directoryName=Path.GetDirectoryName( )
    //    }

    //}
}
