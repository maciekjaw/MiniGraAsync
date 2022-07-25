using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGraAsync
{
    public class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Player(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void CreatePlayers()
        {
            List<Player> players = new List<Player>()
            {
                new Player(Name = "M", Surname = "K"),
                new Player(Name = "L", Surname = "R")
            };
        }

        public void SendMessage(Player p)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello {0}, how are you ?", p.Name);
                Console.ReadLine();
            }
        }

        #region TaskDelay

        public async Task DelayOneSec()
        {
            await Task.Delay(1000);
        }

        public async Task DelayOneSecond()
        {
            await Task.Delay(1000);
        }

        public async Task DelayOneSeconds()
        {
            await Task.Delay(1000);
        }

        #endregion
    }
}
