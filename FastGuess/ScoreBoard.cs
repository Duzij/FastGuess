using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastGuess
{
    public class ScoreBoard
    {
        public string Nickname { get; set; }

        public DateTime Date = DateTime.UtcNow;

        public int Score { get; set; }
    }
}
