﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Critter2FG.Character
{
    public class Class
    {
        public string name { get; set; }
        public int level { get; set; }
        public int casterlevel { get; set; }
        public string hitdie { get; set; }
        public int hitdieused { get; set; }
        public Class(string Name, int Level,string HitDie)
        {
            name = Name;
            level = Level;
            hitdie = HitDie;
        }
    }
}
