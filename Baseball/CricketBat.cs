﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class CricketBat : IBat
    {
        public int WeightInGrams { get; set; }

        public void Swing()
        {
            Console.WriteLine("Cricket!");
        }
    }
}
