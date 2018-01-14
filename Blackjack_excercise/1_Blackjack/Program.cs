using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // All aces are 11 points. In real life, one can choose whether it is 1 or 11 
            // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...  

            //Card deck has 52 cards and 4 suits of cards: spades, hearts, diamonds and clovers. 
            //Each suit has 13 cards: cards of 2 to 10, face cards (jack, queen, king) and ace.
            //Cards 2 to 10 value equals their numerical value, face cards are 10 points each and ace is 11 points.
            //Dealer deals for player to cards face up and for dealer one card face up and one face down.
            //Player needs for winning higher points than dealer/house, but not more than 21, otherwise dealer wins anyway.
            //After being dealt 2 cards, player can choose to have another card.  When player draws a card, house always draws one as-well.




            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            //Define array of cards.
            //Randomly choose 4 cards from card deck of 52 and reveal 3 of them. A card can be chosen only once, then it will be on the table, not in the card deck.
            //int 2S, 3S, 4S, 5S, 6S, 7S, 8S, 9S, 10S, JS, QS, KS, AS;
            //int player1, player2, player3, dealer1, dealer2, dealer3;

            //int[] cardsToGet = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52};

            //help from: https://stackoverflow.com/questions/108819/best-way-to-randomize-an-array-with-net
            string[] Deck = new string[52] {
                "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AS",
                "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH", "AH",
                "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AD",
                "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AC"};

            //vali juhuvalimiga üks kaart (asukohaindeks massiivis), jäta meelde asukohaindeks massiivis, eemalda massiivist, tee nii 4 korda       
            //muutuja (variable =var) rand defineerimine juhuvalikuks
            var rand = new Random();
            //muutuja list defineerimine stringtüüpi ja massiivist Deck
            var list = new List<string>(Deck);

            // Get the next item at random.
            //Muutuja indeks defineerimine juhuslikuks numbriks vahemikus 0 kuni listi objektide arv
            while (list.Count > 48)
            {
                var index = rand.Next(0, list.Count);
                int[] PlayerCards = new int[2];
                for (var i = 0; i < 2; i++)
                    PlayerCards[i] = (rand.Next(0,list.Count));
                var PlayerHand = new string (PlayerCards);
                Console.WriteLine("You have been dealt: " + PlayerHand);
                Console.WriteLine(Deck [index]);
                var item = list[index];
                // Remove the item from the list and push it to the top of the deck.
                list.RemoveAt(index);
            }



            Console.WriteLine("You have been dealt: " + Deck [41] +", " + Deck [17] );
            Console.WriteLine("House has been dealt: 8S, [?]");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();

            int n;
            Console.Write("I choose: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (n == 1)
            {
                while (list.Count > 46)
                {
                    var index = rand.Next(0, list.Count);
                    Console.WriteLine(Deck[index]);
                    var item = list[index];
                    // Remove the item from the list and push it to the top of the deck.
                    list.RemoveAt(index);
                }
                Console.WriteLine("You have been dealt: 4S");
                Console.WriteLine("House has been dealt: [?]");
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.WriteLine();
                Console.WriteLine("I choose: 2");
                Console.WriteLine();
            }
            if (n == 2)

                     

            Console.WriteLine("You have 14 points vs. house 17 points");
            Console.WriteLine("House wins!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
