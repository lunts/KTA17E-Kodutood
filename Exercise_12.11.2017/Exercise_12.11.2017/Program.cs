using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arvutab sisestatud arvu numbrikohtade summa http://www.sanfoundry.com/csharp-programs-generate-sum-digits/
            //Numeroloogia. Sünnikuupäevast elutee numbri arvutamine. Nt sünnipäev on 01.01.1999, siis elutee nr arvutatakse 0+1 + 0+1 + 1+9+9+9= 30 -> 3+0 = 3. Alati jääb ühekohaline arv.
            int p, sum = 0, sum2 = 0, sum3 = 0, r;
            Console.Write("Sisesta sünnikuupäev (PPKKAAA): ");
            p = int.Parse(Console.ReadLine());

            while (p != 0)
            {
                r = p % 10;
                p = p / 10;
                sum = sum + r;
            }

            if (sum < 9)
            {
                Console.Write("Sinu elutee number on: " + sum);
                Console.WriteLine();

            }

            else
            {
                while (sum != 0)
                {
                    r = sum % 10;
                    sum = sum / 10;
                    sum2 = sum2 + r;
                }

                if (sum2 > 9)
                {
                    while (sum2 != 0)
                    {
                        r = sum2 % 10;
                        sum2 = sum2 / 10;
                        sum3 = sum3 + r;
                    }
                    Console.Write("Sinu elutee number on: " + sum3);
                    Console.WriteLine();

                }
                else
                {
                    Console.Write("Sinu elutee number on: " + sum2);
                    Console.WriteLine();

                }
            }


            if ((sum == 1) || (sum2 == 1) || (sum3 == 1))
            {
                Console.WriteLine("\nKui su elutee number on 1, oled sa sünnist saati liidriomadustega. Sa ei karda vastutust enda peale võtta ning suudad inimesi mõjutada, asjadesse kaasata ning samal ajal endale kindlaks jääda. Sa tahad olla individuaalne ja iseseisev. Väga paljud tuntud juhid ja liidrid kannavad 1. elutee numbrit. Sinu parimaid omadusi on võime suuri asju korda saata — oskad väga hästi n-ö palli veerema panna ja uusi projekte luua. Oled oma võimete tipul just siis, kui su teele sattub mõni takistus või raskus, sest ületad need jõu ja uhkusega. Vahel on sul kombeks olukorra juhtimine enda kätesse võtta ka siis, kui seda tegelikult tarvis pole või seda otseselt sobilikuks ei peeta.");
                Console.WriteLine("\nOled väga originaalne ja tahad kõike teha enda käe ja tahte järgi. Ehkki see tuleb tihti kasuks, kipud vahel enda sõna liiga palju maksma panema, nii et teistel ei jää võimalust otsuste tegemisel kaasa rääkida või oma arvamust avaldada. Nii et vahel võid olla pisut liiga enesekeskne. Enamjaolt peetakse sind sõbralikuks ja heaks kaaslaseks ja suurepäraseks vestluskaaslaseks. Sa meeldid inimestele ja neid tõmbab sinu poole. See on väga hea, sest kriitika ei mõju sulle hästi ja võib sind rivist välja lüüa.");
                Console.WriteLine("\nEhkki elutee numbrit 1 peetakse üheks tugevaimaks, kaasnevad sellega ka mõned negatiivsed asjaolud. Sa oled hea juht, kuid üpris halb järgija — ometi tuleb elus vahel teha ka seda, mis kästakse. Sinu suurimaks probleemiks ongi leppimine kellegi teise otsustega, mida sa õigeks ei pea — kui leppida tuleb, siis frustreerib see sind ning tunned end allasurutuna ja eemaletõugatuna. Sa lausa vajad, et ohjad oleksid alati sinu käes. ");
            }

            if ((sum == 2) || (sum2 == 2) || (sum3 == 2))
            {
                Console.WriteLine("\nSisenesid sellesse maailma spirituaalseks “rahuloojaks”. Sinu olulisemad võimed on oskus näha, kuulata ja seda endasse võtta. Sa oled parandaja, ravija ja oma suurepärase rääkimis-, veenmis- ja lepitamisoskusega oleksid ideaalne diplomaat. Sa kasutad oma tahte saamiseks alati pigem veenmist kui jõudu. Võttes oma spirituaalsest poolest viimast, avastad, et oled idealist, kes näeb alati kusagil uusi teid ja võimalusi. Oled äärmiselt huvitav inimene ja ühiskonnale väga kasulik. Oled sügav mõtleja, kelle kätte sobib usaldada elumüsteeriumidele vastuste otsimine. ");
                Console.WriteLine("\nVõid tihti avastada inimesed sinu juurde pöördumast, kas siis murede, probleemide või küsimustega — oskad tülisid lahendada ja rahu luua, inimesi rahustada ja valgustada. Hoolid väga teistest ja soovid alati parimat — oled aus ja avatud kõiges, mida teed või ütled. Sinust saab alati suurepärane tiimiliige — sa ei nõua kunagi tunnustust või vajadust teistest esile tõusta, töötad tiimi nimel ja tiimiga koos. Sa armastad rutiini ja seda, kui asjad on kindlalt paigas. Suured muutused hirmutavad sind. Sinust ei saaks head juhti, kuid see-eest on sul rohkem ideid, kui paljudel teistel. ");
                Console.WriteLine("\nMis on sinu halvemad küljed? Vaatamata sellele, et oled “rahulooja”, võib su elu ola üpris närviline — sulle ei meelti otsuste tegemine või otsustamine, kriisiolukorrad ajavad sind paanikasse ja kui miski ei lähe plaani- või ootuspäraselt, siis raputab see sind rohkem kui teisi. Kui kaldud rohkem 2. elutee numbri negatiivsete omaduste poole, siis oled tõenäoliselt üpris pessimistlik inimene. Võid teha õnnelikuks ja rahulikuks teisi, kuid sisemise rahu leidmine valmistab sulle raskusi. Võib juhtuda, et sul on probleeme tegelikkuse ja fantaasia eristamisega.");
            }

            if ((sum == 3) || (sum2 == 3) || (sum3 == 3))
            {
                Console.WriteLine("\nKui su elutee number on 3, sisenesid sa siia maailma koos tugeva loomingulisuse ja suurepärase suhtlemisoskusega. Kui oled piisavalt andekas, saab sinust suurepärane kirjanik, muusik, kunstnik vms loomeinimene. Inimesed, kes kannavad number kolme on alati teiste jaoks huvitavad, säravad ja ligitõmbavad. Oled harmooniline ja armastad naudinguid — enamasti elad elu täisväärtuslikult ning tihti ei võta sa vaevaks homse pärast muretsemist. Oled muretu loomuga ja seetõttu näiteks rahaasjadega üpris korrapäratu — vajad ja kulutad raha, kui sul seda on ja kui raha pole, ei näe sa ka selle olemasoluks vajadust. ");
                Console.WriteLine("\nArmastad inimesi, suhtlemist ja uute kontaktide loomist. Oled soe ja sõbralik, hea vestluskaaslane, sotsiaalne ja avatud. Inimestele meeldib sind rääkimas kuulata, kuid vajadusel oskad alati olla hea kuulaja. Inimestele meeldib su lähedus, sest paned kõik end justkui kodus tundma — oled avatud südamega ja särav, õnnelik ja alati inspireeritud. Suhtes oled äärmiselt lojaalne ja romantiline, igasuguse truudusetuse suhtes on sul nulltolerants. Vahel kipud pisut suhtedraamat tekitama, kuid seda vajd seetõttu, et vajad pidevat võimalust oma emotsioonid endast välja elada. ");
                Console.WriteLine("\nNumber kolm tähendab ühtlasi, et oled äärmiselt emotsionaalne. Kui sa haiget saad, kipud vaikselt oma kesta alla peituma ja erinevad raskused ja valud elus, eriti lahkuminekud ja lein teevad su hingele väga rohket valu. Kuna sa oled ise emotsionaalne ja südamlik, siis märkad ka teiste inimeste muret kiiresti ja oskad neile kaasa tunda. Sa ei põikle kunagi probleemidest kõrvale — kui mingi jama vajab lahendamist, siis sa ka teed seda, et see seljataha jätta. ");
                Console.WriteLine("\nMis on sinu numbri negatiivsemad küljed? Kipud vahel nägema kõike liiga mustvalgelt. Kõik on kas väga hästi või eriti halvasti. Sul on vahel raskusi grupis töötamisega, sest sa ei talu aeglust, n-ö pikkade juhtmetega inimesi ja seda, kui sa ei näe progressi. Kuna oled suur elunautleja, siis võib juhtuda, et muutud pisut liiga pealiskaudseks, ega pööra piisavalt tähelepanu sisemistele väärtustele. Sa ei talu rutiini ja tunned end siis justkui aheldatult. Püüa olla ka veidi tolerantsem, kuid samas jälgi, et sa liiga optimistlikuks ei muutuks — nii võivad paljud hädaohud märkamata jääda.");
            }

            if ((sum == 4) || (sum2 == 4) || (sum3 == 4))
            {
                Console.WriteLine("\nSul on loomulik anne asju planeerida, parandada, ehitada ja mitte millestki midagi teha. Oled üks usaldusväärsemaid ja praktilisemaid inimesi, kellel on alati jalad maapeal. Kui midagi ette võtad ja selle kallal töötad ja vaeva näed, oled võimeline praktiliselt kõigeks ning võid saavutada meeletu kuulsuse ja tunnustuse. Loomulikult ei tähenda see, et kõik elutee numbrit 4 kandvad inimesed kuulsaks saavad. Sa võtad käsud probleemideta vastu ja viid need ka täide, samas oskad hästi ka ise käsklusi jagada. Mida sa ka ei teeks, annad alati endast parima ja ootad seda ka teistelt.");
                Console.WriteLine("\nSul on meeletu tahtejõud ja seda võidakse tihti segi ajada jäärapäisusega. Kui midagi ette võtad, siis tahad selle korda saata täpselt nii nagu olid planeerinud ja nagu sa ise õigeks pead — ajad alati oma asja, teistest sõltumata. Sinust saaks täpselt selline juht, kelle käe all asjad ka kindlasti tehtud saavad. Oled suurepärane organiseerija ja planeerija, sest vaatad asju ratsionaalselt ja praktiliselt. Planeerimine mängib sinu elus väga tähtsat rolli ja igasugused asjad-mida-teha nimekirjad on sulle väga omased. Funktsioneerid kõige paremini, kui pead kiiresti otsuseid langetama.");
                Console.WriteLine("\nOled lojaalne ja suudad oma pere eest hoolitseda. Sul ei pruugi olla väga palju sõpru, kuid olemasolevatega oled väga lähedane — kui oled kellegagi juba sõprussuhte loonud, jääb see tõenäoliselt igaveseks. Oled keegi, kellele saab alati kindel olla, oled kannatlik ja kindlameelne.");
                Console.WriteLine("\nMis on aga sinu halvem külg? Kipud rutiini jääma ja magama maha suuremad võimalused. Võid olla liiga kitsameelne ja avaldada oma arvamust ka siis, kui seda tarvis pole või see kellelegi haiget võib teha.");
            }

            if ((sum == 5) || (sum2 == 5) || (sum3 == 5))
            {
                Console.WriteLine("\nSinu võtmesõnaks on vabadus. Vajad vabadust ja seda otsides oled seiklushimuline ning kõrge ja kiire mõttelennuga. Oled üks neist inimestest, kes otsib alati millelegi vastust. Vajad pidevat muutust ja arenemist — mitte miski ei tohi sind köita või paigal hoida, sest see ajaks sind lihtsalt hulluks. Oled äärmiselt kaastundlik vabadusearmastaja, mis tähendab, et sa ei hoolitse mitte ainult enda, vaid ka teiste heaolu ja vabaduse eest. Arva, millist elutee numbrit kandis Abraham Lincoln, mees kes lõpetas orjuse Ameerikas? Oled progressiivne mõtleja ja sul on palju potentsiaali valitsuses, õigusalal ja mujal, kus võim ja mõtted on piiramatud.");
                Console.WriteLine("\nOled hea suhtleja ja tead, kuidas inimesi motiveerida. Sulle ei istu igapäevased ülesanded, mis peavad kindlaks ajaks tehtud olema. Vajad tööd, kus saaksid pidevalt areneda ja uusi ideid ellu viia — rutiinne töö pole kohe kindlasti sinu jaoks. Seiklushimu kipub su elus domineerima — igasugused riskid ja katsetused kuuluvad sinuga kokku ja sa otsid pidevalt uusi. Mitte kunagi ei taha sa liiga kaua ühe koha peal olla. Piiratust ei talu sa ka suhtes — see ei tähenda, et oleksid ilmtingimata truudusetu või hüppaksid ühest suhtest teise, kuid sa vajad kinlasti partnerit, kes su vabadusejanu mõistaks. Suhtest, mis on täis armukadedust ja rutiini põgened sa kiiresti. ");
                Console.WriteLine("\nKõige raskemaks teeb su elu püsimatus. Võid vahetada tihti erialasid või töökohti, ilma et jõuaksid midagi erilist saavutada. Oled rahutu ja närviline — võib juhtuda, et pidevalt endale ja oma uutele eesmärkidele keskendudes teed palju haiget inimestele su ümber.");
            }

            if ((sum == 6) || (sum2 == 6) || (sum3 == 6))
            {
                Console.WriteLine("\nSina oled tõe ja õigluse eest seisja, kodukaitsja ja vastutuse enda peale võtja. Sinu vanemlikud võimed on oluliselt paremad, kui teistel. Olgu kodus või tööl, oled alati see, kes teistele õla alla paneb ja neid kaitseb. Kuus on ühtlasi kõige kodusem number — pereväärtused on sulle olulised. Oma väärtustelt oled üpris konservatiivne. Selleks, et end õnnelikuna tunda, pead tundma end kasuliku ja vajalikuna. Tahad anda inimestele nõu, neid teenida või toetada. Sul on kombeks esmalt teistele kasulik olla ja alles siis enda peale mõelda. Oled alati teiste jaoks olemaks ja kipud võtma enda kanda rohkem kui tarvis. ");
                Console.WriteLine("\nSuhtes oled pühendunud ja lojaalne. Kuna sulle meeldib teiste eest hoolitseda, valid endale tihti partneri, kes vajabki rohkem hoolitsust. Vajad suhtes täielikku harmooniat — stress ja tülid kipuvad kergesti su kontrolli alt kaduma. Muide, ka sõprade suhtes oled lojaalne ja toetav, kuid võib ka juhtuda, et kipud olema liiga domineeriv ja kontrolliv. Oled kaastundlik ja väga lahke — sa pole kitsi ei sõnade ega asjadega. Juba noorest east saati mõistad paljusid eluküsimusi paremini kui paljud teised ning see aitab sul alati kindlaks jääda. ");
                Console.WriteLine("\nKahjuks tuleb sulle kalduvus end kohustuste ja lubadustega üle koormata, nii et sul ei jää enda jaoks üldse vaba aega. Nagu juba öeldud, võid olla ka liiga kontrolliv ja domineeriv, mis on ahistav nii su perele, kallimale kui ka sõpradele. Sinu põhiviga on see, et kipud tihti üle pingutama — tagasihoidlikkus ja vaoshoitus on sulle rasked tulema. Inimesed, kes kõnnivad eluteed numbriga 6, kannatavad üldjuhul rohkem kui teised ja neil on ees ka oluliselt rohkem katsumusi.");
            }

            if ((sum == 7) || (sum2 == 7) || (sum3 == 7))
            {
                Console.WriteLine("\nKui kõnnid seitsmendal eluteel, oled väga arukas ja tähelepanelik. Sul on eriline anne asju vaadelda, uurida ja mõistatusi lahendada. Eelkõige oled mõtleja. Analüüsid kiiresti olukordi ja lahendad neid efektiivselt ja imelise täpsusega. Oma töös oled põhjalik ja hoolikas, täielik perfektsionist, kes eeldab, et ka teised tema standarditele vastavad.");
                Console.WriteLine("\nOled rahumeelne ja kirglik hing, kuid valid hoolega inimesi, kellega läbi käid. Tajud kohe ära valed ning hoiad petmisest ja reeturlikkusest kaarega eemale. Sa ei ole üks neist, kellel on suur hulk sõpru, kuid kui kellegi juba enda sõbraks aktsepteerid, jääb ta selleks terveks eluks. Tahad kedagi lähedalt tundma õppida, enne kui talle enda ellu ukse avad. Sa oled arukas ja väga kiire taibuga, kuid mitte eriti sotsiaalne. Sind võidakse pidada veidraks või uhkeks, kuid tegelikult peitub su eemalehoidev olek pigem arguses ja vajaduses pisut “üles soojeneda” enne kui enda ellu uusi inimesi lased. Klubid ja organisatsioonid sind ei huvita — sa ei liitu nendega. ");
                Console.WriteLine("\nSa naudid rahu ja vaikust ning püüad hoida eemale mürast, rahvahulkadest ja segadusest. Tegelikult sobiksidki sa paremini mõnda vanemasse aega, mil elurütm ei olnud nii kiire ja inimesed olid rahumeelsemad. Nagu juba öeldud, sa oled mõtleja ja naudid uute teadmiste kogumist ja neelad neid kõikjalt nagu svamm. Oled intellektuaalne, õpihimuline ja teadus tõmbab sind. Tahad alati ise järelduste ja lahendusteni jõuda ning ajad taga tervet tõde, mitte poolt. ");
                Console.WriteLine("\nSinu halvem omadus on, et võid olla liiga pessimistlik, vaidlev ja ka salalik. Sa ei võta elult kõike, mida see sulle pakub ja sinuga võib olla raske koos elada, sest teistega arvestamine valmistab sulle raskusi. Kipud nägema kõiges halvemat külge ja olema negatiivse suhtumisega. Võid olla isekas ja koguni hellik — see on ühtlasi põhjus, miks väga paljud 7. eluteel käiad elavad üksinda. ");
            }

            if ((sum == 8) || (sum2 == 8) || (sum3 == 8))
            {
                Console.WriteLine("\nKui su elutee number on 8, tahad sa juhtida, suunata, organiseerida ja valitseda. Oled väga tahtejõuline ja eesmärgile pühendunud. Sa tead, kuidas end ja oma ümbrust valitseda. Sinu võime olukordi ja inimesi hinnata mängib alati sinu kasuks. Suur osa edust, mida elus saavutad, tuleb sinu võimest teha rasket tööd. Kõige rohkem töönarkomaane ongi 8. eluteel käijate seas. Sa tunned ära head ja andekad inimesed ning oskad neid inspireerida — see teeb sinust suurepärase liidri. Oled oma pingutustes praktiline ja sihikindel, julge ja arukas. Tead alati, mida teha, et edasi jõuda.");
                Console.WriteLine("\nOn suur tõenäosus, et oled üks neist, kes püüab raske tööga saavutada endale võimalikult head materiaalset kindlustatust. Sa tahad ka olla hinnatud ja tunnustatud, igasugused tiitlid ja aumärgid on sulle äärmiselt olulised. Võid end leida võistleval alal tegutsemast.");
                Console.WriteLine("\nSuhtes oled otsekohene ja aus. Võid olla väga armunud, kuid jälgi, et sul poleks liiga kiire, et seda ka välja näidata. Võid kippuda unustama, et suhtes on peale materiaalse toetamise oluline ka tunnete jagamine. Sa vajad lähedast romantilist suhet, mis pehmendaks su muidu töökat ja kõva iseloomu. Jälgi, et sul oleks armastuse jaoks alati aega ning et sa laseks sel olla üks suur osa oma elust. ");
                Console.WriteLine("\nSinu üks halvemaid omadusi on kalduvus olla diktaatorlik — kipud inimesi oma arvamuse ja liigse entusiasmiga alla suruma. Võid olla liiga materiaalne ja ahne ning selle kõrvalt pere või suhte unarusse jätta. Vajadus edu saavutada võib muutuda lausa haiguseks ning selle tulemusena muutud üksikuks ja eraklikuks. Parim soovitus sulle? Ära unusta inimesi ja tundeid!");
            }

            if ((sum == 9) || (sum2 == 9) || (sum3 == 9))
            {
                Console.WriteLine("\nOled emotsionaalne, isegi pisut dramaatiline inimene, kes on alati helde ja kaastundlik. Tavaliselt on inimesed, kelle elutee number on 9, väga au- ja usaldusväärsed ning ei tekita endale kunagi liigseid eelarvamusi. Sul on siiralt kahju neist, keda pole niimoodi õnnistatud nagu sind ja kui vähegi võimalik, siis sa alati aitad. Oled üks neist, kes ka oma peenraha kerjusele annab. Üheksa kui kõrgeim ühekohaline number annab sulle loomuomaduseks tunda vastutust ja hoolivust kõigi teiste suhtes.");
                Console.WriteLine("\nMateriaalsed väärtused pole sinu jaoks nii olulised, ometi on väike tõenäosus, et kunagi hätta sattud või millestki suurest ilma jääd. Sinu eesmärk pole kohe kindlasti rikkaks saamine, sest sa mõtled pigem teistele kui endale. Sa ei suhtud rahasse kui vahendisse, mitte eesmärki omaette. ");
                Console.WriteLine("\nSuure tõenäosusega on sul väga lai tutvusringkond — inimesi tõmbab su siiruse ja avatuse poole. Tihti määratakse sulle juhtiv roll, sest sind usaldatakse ja austatakse. Sinu suhe kulgeb edukalt, kui su partner on sama leebe jagaja kui sa ise. Kui ta on aga veidi materiaalsem või rahaahnem, tõusevad probleemid kiiresti. Oled tundlik ja tahad kõike sind ümbritsevat mõista ja tajuda. Võid olla kunstnik või kirjanik — keegi, kes otsib alati oma tunnetele mingisugust väljundit. ");
                Console.WriteLine("\nSinu ainus negatiivsus võib olla vastand su parimale küljele — võid olla hoopis äärmiselt isekas ja võimetu mõistma, miks peaks andmine ja jagamine sulle mingisugust rahuldust pakkma. Võid sattuda segadusse, kui keegi on sinuga eri arvamusel ja ahastusse, kui sa tahad teha midagi võimatut.");
            }

            Console.Read();

        }
    }
}
