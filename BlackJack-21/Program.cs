using System;

namespace BlackJack_21
{
    class Program
    {
        static void Main(string[] args)
        {


            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player;
            game += player;
            game -= player;


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
    

    
