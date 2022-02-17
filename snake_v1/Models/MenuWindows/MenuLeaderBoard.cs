using snake_v1.Enums;
using snake_v1.Models.History;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace snake_v1.Models.MenuWindows
{
    public class MenuLeaderBoard : Menu
    {
        private string _fileName;

        public static string FileName { get; set; } = "save.txt";

        private List<Player> _players;
        List<Player> Players
        {
            get
            {

                // _players.

                return _players;
            }
            set => _players = value;
        }

        public MenuLeaderBoard(Game game) : base(game)
        {
            _fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + FileName;

            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }

            Players = new();
        }

        public void SaveHiScorePlayer()
        {
            Players = Players.OrderByDescending(x => x.HiScoreThisPlayer).ToList();

            Player existPlayer = Players.FirstOrDefault(x => x.Name == Game.CurrentPlayer.Name);

            if (Players.Count == 10 && Players.Last().HiScoreThisPlayer < Game.CurrentPlayer.HiScoreThisPlayer)
            {
                return;
            }

            if (existPlayer == null && Players.Count < 10)
            {
                Players.Add(Game.CurrentPlayer);
            }
            else if (existPlayer == null && Players.Count == 10 && Players.Last().HiScoreThisPlayer < Game.CurrentPlayer.HiScoreThisPlayer)
            {
                Players.Remove(Players.Last());
                Players.Add(Game.CurrentPlayer);
            }

            else if (existPlayer != null && existPlayer.HiScoreThisPlayer < Game.CurrentPlayer.HiScoreThisPlayer)
            {
                //TODO проверить работу
                Players.Remove(existPlayer);
                Players.Add(Game.CurrentPlayer);

            }

        }

        public override void Init()
        {
            Players = Players.OrderByDescending(x => x.HiScoreThisPlayer).ToList();

            Console.Clear();

            MenuItems.Clear();

            MenuItems.Add(new MenuItemLabel("Header", 95, 1, ConsoleColor.Red, "Таблица лидеров"));

            foreach (var player in Players)
            {
                MenuItems.Add(new MenuItemLabel("MenuItem", 80, TopMargin: 1, MenuItems.Last(), ConsoleColor.Green, $"{player.Name}  {player.HiScoreThisPlayer}", Align.left));
            }

            Draw();
            Console.ReadKey();
        }
    }
}
