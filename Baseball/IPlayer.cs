using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Number { get; set; }

        void TakeTurn(IBat bat);
    }
}
