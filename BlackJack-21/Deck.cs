﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_21
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Cubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces) 
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(Deck deck, int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards.[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
