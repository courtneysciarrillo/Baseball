using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class CricketPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public CricketPlayer()
        {

        }

        public CricketPlayer(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public void TakeTurn(IBat bat)
        {
            bat.Swing();
        }
    }
}
