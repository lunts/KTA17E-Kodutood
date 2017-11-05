using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_exercise_04._11._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kehamassiindeksi (KMI) arvutamine. Kehamassiindeksi arvutamine ei sobi laste, rasedate ja tegevsportlaste seisundi hindamiseks, kuna rasvaprotsendi norm on nende puhul suhteline või ei ole teada.");
            Console.WriteLine();

            Console.Write("Sisesta kaal (kg): ");
            string kaal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Sisesta pikkus (cm): ");
            string pikkus = Console.ReadLine();

            decimal Kaal = decimal.Parse(kaal); //UUS! muudab teksti komadega arvuks
            decimal Pikkus = decimal.Parse(pikkus);

            decimal KMI = Kaal / ((Pikkus/100) * (Pikkus/100)); //KMI arvutamise valem
            Console.WriteLine();
            Console.WriteLine($"Sinu KMI on {Math.Round(KMI, 2)}"); //UUS! KMI ümardus

            if (KMI < 18.5m)
            {
                Console.WriteLine("Oled alakaaluline.");
            }


            if (KMI >= 18.5m & KMI <25m)
            {
                 Console.WriteLine("Oled normaalkaalus.");
            }    

            if (KMI >= 25m & KMI < 30m)
            {
                Console.WriteLine("Oled ülekaalus.");
            }

            if (KMI >= 30m & KMI < 35m)
            {
                Console.WriteLine("Oled rasvumise I astmel.");
            }

            if (KMI >= 35m & KMI < 40m)
            {
                Console.WriteLine("Oled rasvumise II astmel.");
            }

            if (KMI > 40m)
            {
                Console.WriteLine("Oled rasvumise III astmel.");
            }


            Console.ReadLine();
        }
    }
}
