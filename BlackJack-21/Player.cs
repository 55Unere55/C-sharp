using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_21
{
   public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
