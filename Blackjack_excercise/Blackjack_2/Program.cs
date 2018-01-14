using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_2
{
    class Program
    {
        enum Cards
        {   S2, H2, D2, C2,
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
            int Player1 = (int)Cards.H4;
            Console.WriteLine("Mängija kaart {0}", Player1);
            Console.ReadKey();


            string[] Deck = new string[52] {
            "S2", "H2", "D2", "C2",
            "S3", "H3", "D3", "C3",
            "S4", "H4", "D4", "C4",
            "S5", "H5", "D5", "C5",
            "S6", "H6", "D6", "C6",
            "S7", "H7", "D7", "C7",
            "S8", "H8", "D8", "C8",
            "S9", "H9", "D9", "C9",
            "S10", "H10", "D10", "C10",
            "JS", "JH", "JD", "JC",
            "QS", "QH", "QD", "QC",
            "KS", "KH", "KD", "KC",
            "AS", "AH", "AD", "AC",};

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
                Console.WriteLine(Deck[index]);
                var item = list[index];
                // Remove the item from the list and push it to the top of the deck.
                list.RemoveAt(index);
            }



            Console.WriteLine("You have been dealt: " + Deck[41] + ", " + Deck[17]);
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
