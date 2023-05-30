using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_21
{
   public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck, Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C\Users\tamar\Logs\log.txt", true))
            {
                file.WrriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }

    }
}
