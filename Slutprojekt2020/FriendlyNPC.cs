﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
    class FriendlyNPC : NPC
    {
        public int friendlyScary = -5;
        public FriendlyNPC()
        {
             friendlyScary += npcStats[0];
        }
    }
}