using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Loo programm mis kuvab kasutajale välja teksti stiilis : „Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata“. 
            //Defineerite selle suvalise numbri esialgu ise. Küsite kasutaja käest sisendit ning kuvate vastuseks, et kas arvuti valitud number on suurem või siis väiksem. 
            //2.Täiendate eelnevat programmi nii, et lisaks suuremale ja väiksemale kontrollide ka võrdelisust. 
            //Kui kasutaja sisestab sama numbri mis arvuti valis(veel käsitsi defineeritud) siis ütleb, et „Arvasid numbri ära“. 
            //3.Täiendage eelnevat programmi nii, et arvuti valib numbri nüüd juba automaatselt.
            //4.Täiendage eelnevat programmi nii, et pärast kasutaja pakkumist arvuti kuvab kas pakutud number on suurem või väiksem.
            //Seejärel annab kasutajale uue võimaluse pakkumiseks. See käib niikaua kuni lõpuks kasutaja arvab õige numbri ära. 
            //Selleks kasutada while tsükklit ning ühte muutujat(tingimuslausena while’s, kas number on ära arvatud või mitte)
            //5.Muutke eelnevat programmi nii, et kasutate while (true) tsükklit ning väljute tsüklist kasutades keyword’i ’break’

            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 - 100]. Proovi see ära arvata.");
            Console.Write("Sisesta number: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Random rnd = new Random();

            int ComputerNumber = rnd.Next(1, 100);

            while (true)
            {             
                if (ComputerNumber > number)
                {
                    Console.WriteLine("Arvuti valitud arv on suurem");
                    Console.Write("Sisesta arv: ");
                    input = Console.ReadLine();
                    number = int.Parse(input);
                }

                if (ComputerNumber < number)
                {
                    Console.WriteLine("Arvuti valitud arv on väiksem");
                    Console.Write("Sisesta arv: ");
                    input = Console.ReadLine();
                    number = int.Parse(input);
                }

                if (ComputerNumber == number) 
                {
                    Console.WriteLine("Tubli! Arvasid arvu ära.");
                    break;
                }
                
               
            }




            Console.ReadLine();

        }
    }
}
