using System;

namespace BlackJack_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            Deck deck = new Deck();
            Deck.Shuffle(3);
            

            foreach (Card cards in deck.Cards)
            {
                Console.WriteLine(cards.Face + " of " + cards.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine(); 
        }
     
            }
        }
    

    
