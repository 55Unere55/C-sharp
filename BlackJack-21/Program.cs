using System;

namespace BlackJack_TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);
            deck Shuffle(deck, out timesShuffled, 3);

            foreach (Card cards in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }
        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add.(deck.Cards.[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }

                return deck;
            }
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
            {
                for (int i = 0; i < times; i++)
                {
                    deck = Shuffle(deck);
                }
                return deck;
            }
        }
    }
}

    
