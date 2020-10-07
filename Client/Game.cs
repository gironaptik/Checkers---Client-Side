﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Game
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
