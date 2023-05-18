using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_21
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
           throw new NotFiniteNumberException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
