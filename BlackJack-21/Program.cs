using System;

namespace BlackJack_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Deck.Shuffle(3);
            

            foreach (Card cards in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine(); 
        }
      //  public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
       //     {
        //        for (int i = 0; i < times; i++)
        //        {
        //            deck = Shuffle(deck);
         //       }
        //        return deck;
            }
        }
    

    
