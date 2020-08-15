using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackCSp
{
    class Player
    {

    }
    class Dealer
    {

    }

    class Card
    {

    }

    class Program
    {
        static List<string> ShuffledDeck()
        {
            var randomNumberGenerator = new Random();
            var ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            var deck = new List<string>();
            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    deck.Add($"{rank} of {suit}");
                }
            }
            for (var index = deck.Count() - 1; index >= 0; index--)
            {
                var randomNumber = randomNumberGenerator.Next(52);
                var swapCards = deck[index];
                deck[index] = deck[randomNumber];
                deck[randomNumber] = swapCards;
            };
            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
            return deck;
        }

        static void DisplayGreeting()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DisplayGreeting();
        }
    }
}