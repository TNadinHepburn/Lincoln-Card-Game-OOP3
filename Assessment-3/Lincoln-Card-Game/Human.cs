﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lincoln_Card_Game
{
    public class Human : Player //inherits from player class
    {
        public override int ID { get; protected set; }

        public Human(List<Card> cards) : base(cards)
        {
            ID = 0;
        }

        public List<Card> PlayCards()
        {
            List<Card> currentHand = new List<Card>();
            Console.WriteLine(Hand);
            Console.WriteLine("Choose 2 Cards to play");
            for(int i = 0; i < 2; i++)
            {
                currentHand.Add(Hand.Cards[UserIntValue(i)]);
            }
            return currentHand;
        }

        public int UserIntValue(int cardNo) 
        {
            int cardIndex;
            while (true)
            {
                Console.Write($"Card {cardNo}: ");
                //accept input if it is a number
                try
                {
                    cardIndex = int.Parse(Console.ReadLine());
                    if(cardIndex < Hand.Cards.Count && cardIndex > 0)
                    {
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number from the range.");
                    }

                }
                catch 
                {
                    Console.WriteLine("Please enter a number.");
                }

            }

            return cardIndex;
        }
    }
}
