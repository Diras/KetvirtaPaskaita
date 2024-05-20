

using _05Uzduotis;
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis05
    {
        public static void Main(string[] args)
        {
            /*Užduotis Bibliotekos Valdymo Sistema
                Aprašymas
                Sukurkite bibliotekos valdymo sistemą, kuri leis sekti knygas ir jų paskolą.
                Sukurkite klasę Knyga su šiais laukais:
                Id (int)
                Pavadinimas (string)
                Autorius (string)
                YraPaskolinta (bool)
                Sukurkite klasę Biblioteka, kuri turės metodus:
                PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
                SalintiKnyga(int id): Pašalina knygą pagal ID.
                PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
                GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
                RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
                RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.
                Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus 
            (pvz., pridėti knygą, pašalinti knygą, paskolinti knygą, grąžinti knygą, 
            rodyti visas knygas, rodyti paskolintas knygas).
             * */

            Console.WriteLine("Bibliotekos valdymo programa 2024 Ver 0.1");
            Console.WriteLine("Paspauskite 1, kad prideti knyga.");
            Console.WriteLine("Paspauskite 2, kad pasalinti knyga.");
            Console.WriteLine("Paspauskite 3, kad paskolinti knyga.");
            Console.WriteLine("Paspauskite 4, kad grazinti knyga.");
            Console.WriteLine("Paspauskite 5, kad parodyti visas knygas.");
            Console.WriteLine("Paspauskite 6, kad parodyti paskolintas knygas.");
            Console.WriteLine("Paspauskite 7, kad iseiti is programos.");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
            }

            while (number != 7)
            {


                switch (number)
                {
                    case 1:

                        Console.WriteLine("Knygos ivedimas...");

                        int id = Biblioteka.biblioteka.Count + 1;

                        Console.WriteLine("Iveskite pavadinima...");
                        string pavadinimas = Console.ReadLine();
                        Console.WriteLine("Iveskite autoriu...");
                        string autorius = Console.ReadLine();

                        Biblioteka.biblioteka.Add(new Knyga(id, pavadinimas, autorius, false));
                        Console.WriteLine("Knyga prideta");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Pasirinkote knygos pasalinima is bibliotekos.");
                        Console.WriteLine("Iveskite knygos Id kuria norite pasalinti...");
                        int deleteId;
                        while (!int.TryParse(Console.ReadLine(), out deleteId))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Biblioteka.SalintiKnyga(deleteId);
                        Console.WriteLine("Knyga pasalinta");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Knygos paskolinimas...");
                        Console.WriteLine("Iveskite knygos Id kuria norite paskolinti...");

                        int paskolintiId;
                        while (!int.TryParse(Console.ReadLine(), out paskolintiId))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }
                        Biblioteka.PaskolintiKnyga(paskolintiId);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Knygos grazinimas...");
                        Console.WriteLine("Iveskite knygos Id kuria norite grazinti...");

                        int grazintiId;
                        while (!int.TryParse(Console.ReadLine(), out grazintiId))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }
                        Biblioteka.GrazintiKnyga(grazintiId);
                        Console.WriteLine();

                        break;
                    case 5:
                        Biblioteka.ShowAllBooks();
                        Console.WriteLine();
                        break;

                    case 6:
                        Biblioteka.ParodytiPaskolintasKnygas();
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Bibliotekos valdymo programa 2024 Ver 0.1");
                Console.WriteLine("Paspauskite 1, kad prideti knyga.");
                Console.WriteLine("Paspauskite 2, kad pasalinti knyga.");
                Console.WriteLine("Paspauskite 3, kad paskolinti knyga.");
                Console.WriteLine("Paspauskite 4, kad grazinti knyga.");
                Console.WriteLine("Paspauskite 5, kad parodyti visas knygas.");
                Console.WriteLine("Paspauskite 6, kad parodyti paskolintas knygas.");
                Console.WriteLine("Paspauskite 7, kad iseiti is programos.");

                

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                }
            }

        }


    }
}
