﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}
        public void evolve(int statIncrease = 5)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                var stat = stats[i];

                stats[i] = new KeyValuePair<string, int>(stat.Key, stat.Value + (stat.Value / 2));
            }
        }
    }
}
