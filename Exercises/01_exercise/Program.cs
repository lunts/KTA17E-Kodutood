using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Loo programm mis kuvab kasutajale välja teksti stiilis : „Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. 
            //Proovi see ära arvata“. Defineerite selle suvalise numbri esialgu ise. Küsite kasutaja käest sisendit ning kuvate vastuseks, et kas arvuti valitud number on suurem või siis väiksem.

            Console.WriteLine();
            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1-100]. Proovi see ära arvata.");
            Console.Write("Sisesta arv: ");
            
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int ComputerNumber = 67;

            Console.WriteLine();

            if (ComputerNumber > number)
            {
                Console.WriteLine($"Arvuti valitud number on {number}-st suurem.");
            }
            if (ComputerNumber < number)
            {
                Console.WriteLine($"Arvuti valitud number on {number}-st väiksem.");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");

            Console.ReadLine();
        }
    }
}
