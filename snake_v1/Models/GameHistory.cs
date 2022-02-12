using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v1.Models
{
    public class GameHistory
    {
        private string _fileName;
        public GameHistory(string fileName)
        {
            _fileName=AppDomain.CurrentDomain.BaseDirectory.ToString()+fileName;

            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }
        }

        private string[] SearchFileToSave(string fileName)
        {
            String currentPath = AppDomain.CurrentDomain.BaseDirectory.ToString();

            string[] files = Directory.GetFiles(currentPath);

            //foreach (var file in files)
            //{
            //    if (File.GetAttributes().ToString == fileName)
            //    {
            //        _currentFile = file;
            //    }
            //}

            return files;
        }
    }
}
