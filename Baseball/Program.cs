using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer hank = new BaseballPlayer();
            CricketPlayer courtney = new CricketPlayer();
            WoodenBat woodenBat = new WoodenBat();
            AluminumBat aluminumBat = new AluminumBat();
            CompositeBat compositeBat = new CompositeBat();
            CricketBat cricketBat = new CricketBat();

            hank.TakeTurn(woodenBat);
            hank.TakeTurn(aluminumBat);
            hank.TakeTurn(compositeBat);

            Console.WriteLine();

            courtney.TakeTurn(cricketBat);

            Console.WriteLine();
        }
    }
}
