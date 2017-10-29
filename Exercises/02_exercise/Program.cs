using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Loo programm mis kuvab kasutajale välja teksti stiilis : „Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata“. 
            //Defineerite selle suvalise numbri esialgu ise. Küsite kasutaja käest sisendit ning kuvate vastuseks, et kas arvuti valitud number on suurem või siis väiksem. 

            //2.Täiendate eelnevat programmi nii, et lisaks suuremale ja väiksemale kontrollide ka võrdelisust. 
            //Kui kasutaja sisestab sama numbri mis arvuti valis(veel käsitsi defineeritud) siis ütleb, et „Arvasid numbri ära“. 

            Console.WriteLine("Ma valin välja ühe suvalise arvu vahemikus [1-100]. Proovi see ära arvata.");
            Console.Write("Sisesta arv: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            int ComputerNumber = 67;

            Console.WriteLine();

            if(ComputerNumber > number)
            {
                Console.WriteLine("Arvuti valitud arv on suurem.");
            }

            if(ComputerNumber < number)
            {
                Console.WriteLine("Arvuti valitud arv on väiksem.");
            }

            if(ComputerNumber == number)
            {
                Console.WriteLine("Tubli! Arvasid arvu ära.");
            }
            Console.WriteLine("Press any key to continue.");

            Console.ReadLine();
        }
    }
}
