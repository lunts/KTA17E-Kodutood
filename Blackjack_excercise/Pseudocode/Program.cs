using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Blackjack’i mängu (diiler ja mängija), või otsige YouTube’st mõni sarnane video ning pange kõik kirja mis näete.. 
            //Kujutage ette, et Teil on sõber kes on pime ja kurt. Ainukene viis kuidas temani info jõuab on pimekirjas. 
            //Kirjutage selline tekst mille põhjal see sõber oskaks seletada mis asi see blackjack on, 
            //kuidas seda mängitakse ning tooge ka paar mängukäte näidet ja tulemust.. 

            //Mängija istub Blackjack lauda ning on diileriga kahekesi. 
            //Alustavad esimese käe mängimist. Diiler jagab mängijale 2 kaarti, nägu allapoole. 
            //Seejärel jagab diiler endale 2 kaarti, millest üks on nägu allapoole ning teine ülespoole..


            // All aces are 11 points. In real life, one can choose whether it is 1 or 11 
            // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...   



         
                Console.WriteLine("Welcome to the game of Blackjack!");
                Console.WriteLine();
                
                Console.WriteLine("You have been dealt: 4C, 6H");
                Console.WriteLine("House has been dealt: 8S, [?]");
                Console.WriteLine();
               
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.WriteLine();
                Console.WriteLine("I choose: 1");
                Console.WriteLine();
                
                
                Console.WriteLine("You have been dealt: 4S");
                Console.WriteLine("House has been dealt: [?]");
                Console.WriteLine();
                


                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.WriteLine();
                Console.WriteLine("I choose: 2");
                Console.WriteLine();
                
                Console.WriteLine("You have 14 points vs. house 17 points");
                Console.WriteLine("House wins!");
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key");
                Console.ReadKey();
         }


        }
    }

