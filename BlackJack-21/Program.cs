using System;

namespace BlackJack_TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();


            foreach (Card cards in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
