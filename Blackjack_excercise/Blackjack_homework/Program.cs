using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_homework
{
    class Program
    {
        public enum Cards
        {
            S2, H2, D2, C2,
            S3, H3, D3, C3,
            S4, H4, D4, C4,
            S5, H5, D5, C5,
            S6, H6, D6, C6,
            S7, H7, D7, C7,
            S8, H8, D8, C8,
            S9, H9, D9, C9,
            S10, H10, D10, C10,
            JS, JH, JD, JC,
            QS, QH, QD, QC,
            KS, KH, KD, KC,
            AS, AH, AD, AC,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var PlayerCards = Cards.random
            var random = new Random();
            int[] PlayerCards = new int[2];
            for (var i = 0; i < 52; i++)
                PlayerCards[i] = (random.Next(1,52));
            Console.WriteLine("You have been dealt: " + PlayerCards[0] + ", " + PlayerCards[1]);

        }
    }
}
