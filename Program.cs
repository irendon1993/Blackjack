using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackCSp
{
    class Player
    {
        public int HandValue { get; set; }
        // public List hand[];
    }

    class Dealer
    {
        public int handValue { get; set; }
    }

    class Card
    {
        public string Name { get; set; }
        public int cardValue(string name)
        {
            if (name.Contains("Ace"))
            {
                return 11;
            }
            else if (name.Contains("Two"))
            {
                return 2;
            }
            else if (name.Contains("Three"))
            {
                return 3;
            }
            else if (name.Contains("Four"))
            {
                return 4;
            }
            else if (name.Contains("Five"))
            {
                return 5;
            }
            else if (name.Contains("Six"))
            {
                return 6;
            }
            else if (name.Contains("Seven"))
            {
                return 7;
            }
            else if (name.Contains("Eight"))
            {
                return 8;
            }
            else if (name.Contains("Nine"))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
    }
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to Blackjack!");
        }
        static string PromptForString(string prompt)
        {
            // First work to do is to print the prompt
            Console.Write(prompt);

            // Get the user input
            var userInput = Console.ReadLine();

            // The return keyword means whatever follows
            // is the OUTPUT of our method
            return userInput;
        }

        static int dealtHand()
        {

            cardValue1 = cardValue(playerHand[0]);
            cardValue2 = cardValue(playerHand[1]);

            var handValue = cardValue1 + cardValue2;
            return handValue;
        }

        static List<Card> createHand(List<string> deck, int index)
        {
            var hand = new List<Card>();

            var newCard = new Card()
            {
                Name = deck[index]
            }

          for (var i = deck[index]; i < 2; i++)
            {
                hand.Add(newCard);
                deck.RemoveAt(i);
            }
        }
        getScore()
        {
            var score = 0;
            for (var i = 0; i < cardArray.length; i++)

                return score;
        }
    }


    updateScores()
    {
        dealerScore = getScore(dealerCards)
              if (playerStay == true)
        {
            return dealerScore;
        }


        playerScore = getScore(playerCards)
              return playerScore;
    }


    checkScore()
    {
        updateScores()
              if (playerScore == 21)
        {
            playerWon = true
                endOfGame()
              }

        if (playerScore > 21)
        {
            playerWon = false
              endOfGame()
              }

        if (dealerScore > 21)
        {
            playerWon = true
              endOfGame()
            }


        endOfGame()
            {
            updateScores()
              playerScore = getScore(playerScore)
              if (playerWon == true)
            {
                return "You won";
            }
            else
            {
                return "sorry you lost";
            }
        }


    }

    static void Main(string[] args)
    {
        var playerWon = false;
        var playerStay = false;




        DisplayGreeting();
        //             var index = 0;
        //             var deck = shuffledDeck();


        //             var player = new Player()

        //             {
        //                 HandValue =
        //             }

        //             var dealer = new Dealer()
        //             {
        //                 handValue =


        //             }

        static List<string> shuffledDeck()
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
            for (var rightIndex = deck.Count() - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deck[rightIndex];
                var rightCard = deck[leftIndex];
                deck[rightIndex] = rightCard;
                deck[leftIndex] = leftCard;
                // return deck;
            }


            // Console.WriteLine("Player has drawn:");
            // Console.WriteLine(deck[0]);
            // Console.WriteLine(deck[1]);


            var playerHand = new List<createHand>();
            var dealerHand = new List<createHand>();

            var playerScore = dealtHand(playerHand);
            var dealerScore = dealtHand(dealerScore)


           var keepHitting = true;


            checkScore();


            while (keepHitting == true)
            {

                var hitCard = new Card()
                {
                    Name = deck[index]
                }
  
            hand.Add(hitCard);
                deck.RemoveAt(i);

                updateScore();

                var answer = PromptForString("Would you like to keep hitting?");

                if (answer = "yes")
                {
                    keepHitting = true;
                }
                else
                {
                    keepHitting = false;
                    updateScore();
                }
            }

            var playerStay()
            {
                playerStay = true;
                Console.WriteLine(dealerCards[0]);
                Console.WriteLine([1]);
    }

    endOfGame();

}
          } 

       

            // playAgain()





        }

    }
  }
}