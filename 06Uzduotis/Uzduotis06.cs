using _06Uzduotis;
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis06
    {
        public static void Main(string[] args)
        {
            /*Užduotis : 
             * Sukurkite restorano užsakymų valdymo sistemą, 
             * kuri leis sekti klientų užsakymus ir užsakytų patiekalų būseną.
                Sukurkite klasę Patiekalas su šiais laukais:
                Id (int)
                Pavadinimas (string)
                Kaina (double)
                Busena (string) – gali būti "Laukiama", "Ruošiama", "Paruošta"

                Sukurkite klasę Uzsakymas su šiais laukais:
                Id (int)
                Klientas (string)
                Patiekalai (List<Patiekalas>)

                Sukurkite klasę Restoranas, kuri turės metodus:
                PridetiPatiekalaIPateikalauSarasa(Patiekalas patiekalas): 
                    Prideda patiekalą į restorano meniu.
                RodytiVisusPatiekalus(): Išspausdina visų patiekalų sąrašą.
                PridetiUzsakyma(Uzsakymas uzsakymas): Prideda naują užsakymą.
                KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena): 
                    Keičia patiekalo būseną užsakyme.
                RodytiVisusUzsakymus(): Išspausdina visų užsakymų sąrašą.
                RodytiUzsakyma(int uzsakymoId): Išspausdina konkretaus užsakymo informaciją.
                Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus 
                        (pvz., pridėti patiekalą į meniu, rodyti visus patiekalus, 
                        pridėti užsakymą, keisti patiekalo būseną, rodyti visus užsakymus, 
                        rodyti konkretaus užsakymo informaciją).
             * */


            Console.WriteLine("Restorano uzsakymu valdymo programa 2024 Ver 0.1");
            Console.WriteLine("Paspauskite 1, kad prideti patiekala i meniu.");
            Console.WriteLine("Paspauskite 2, kad parodyti visus patiekalus.");
            Console.WriteLine("Paspauskite 3, kad prideti uzsakyma.");
            Console.WriteLine("Paspauskite 4, kad keisti patiekalo busena.");
            Console.WriteLine("Paspauskite 5, kad parodyti visus uzsakymus");
            Console.WriteLine("Paspauskite 6, kad parodyti konkretaus uzsakymo informacija.");
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

                        Console.WriteLine("------------------------");
                        Console.WriteLine("Patiekalo pridejimas...");

                        int id = Restoranas.Meniu.Count + 1;

                        Console.WriteLine("Iveskite pavadinima...");
                        string pavadinimas = Console.ReadLine();

                        Console.WriteLine("Iveskite kaina...");
                        double kaina;
                        while (!double.TryParse(Console.ReadLine(), out kaina))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Restoranas.PridetiPatiekalaIMeniu(new Patiekalas(id, pavadinimas, kaina));
                        Console.WriteLine("Patiekalas pridetas");
                        Console.WriteLine("------------------------");
                        break;

                    case 2:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Visi patiekalai is meniu:");
                        Restoranas.RodytiVisusPatiekalus();
                        Console.WriteLine("------------------------");
                        break;

                    case 3:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Uzsakymo pridejimas...");
                        

                        int uzsakymoId = Uzsakymas.UzsakymuSarasas.Count + 1;

                        Console.WriteLine("Iveskite klienta pavadinima...");
                        string klientas = Console.ReadLine();

                        Console.WriteLine("Iveskite kiek patiekalu bus uzsakyme...");
                        int patiekaluSkaicius;
                        while(!int.TryParse(Console.ReadLine(), out patiekaluSkaicius))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Restoranas.PridetiUzsakyma(new Uzsakymas(uzsakymoId, klientas, new List<Patiekalas>() ));

                        int patiekaloId = 0;

                        while (patiekaluSkaicius != 0)
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Visi patiekalai is meniu:");
                            Restoranas.RodytiVisusPatiekalus();

                            Console.WriteLine("Iveskite patiekalo Id kuri norite uzsakyti...");
                            

                            while (!int.TryParse(Console.ReadLine(), out patiekaloId))
                            {
                                Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                            }

                            Uzsakymas.PridetiPatiekala(Restoranas.SurastiPatiekalaPagalId(patiekaloId), uzsakymoId);
                            

                            
                            Console.WriteLine("Patiekalas pridetas");
                            patiekaluSkaicius--;
                        }

                        Restoranas.KeistiPatiekaloBusena(uzsakymoId, patiekaloId, "Laukiama");

                        Console.WriteLine("------------------------");

                        break;

                    case 4:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Patiekalo busenos keitimas...");
                        Console.WriteLine("Uzsakymu sarasas:");
                        Uzsakymas.PrintSarasas();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Iveskite uzsakymo Id...");
                        int uzsakymId = 0;
                        while (!int.TryParse(Console.ReadLine(), out uzsakymId) && uzsakymId > 0 && uzsakymId < Uzsakymas.UzsakymuSarasas.Count)
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Console.WriteLine("Uzsakymo Id:" + uzsakymId + "Patiekalu sarasas:" );
                        Uzsakymas.PrintPatikalusIsUzsakimo(Uzsakymas.SurastiUzsakymaPagalId(uzsakymId));
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Iveskite patiekalo Id...");
                        int patiekalId = 0;
                        while (!int.TryParse(Console.ReadLine(), out patiekalId) && patiekalId > 0 && patiekalId < Uzsakymas.SurastiUzsakymaPagalId(uzsakymId).Patiekalai.Count)
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Pairinkite uzsakymo busena:");
                        Console.WriteLine("1. Laukiama");
                        Console.WriteLine("2. Ruosiama");
                        Console.WriteLine("3. Paruosta");

                        int busena = 0;
                        string busenaText;
                        while (!int.TryParse(Console.ReadLine(), out busena) && busena > 0 && busena < 4)
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        if(busena == 1)
                        {
                            busenaText = "Laukiama";
                        }
                        else if (busena == 2)
                        {
                            busenaText = "Ruosiama";
                        }
                        else
                        {
                            busenaText = "Paruosta";
                        }

                        Restoranas.KeistiPatiekaloBusena(uzsakymId, patiekalId, busenaText);

                        Console.WriteLine("Busena pakeista!");
                        Console.WriteLine("------------------------");
                        break;
                    case 5:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Visi uzsakymai:");
                        Uzsakymas.PrintSarasas();

                        Console.WriteLine("------------------------");
                        break;

                    case 6:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Uzsakymu sarasas:");
                        Uzsakymas.PrintSarasas();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Iveskite uzsakymo Id...");
                        int uzsakId = 0;
                        while (!int.TryParse(Console.ReadLine(), out uzsakId) && uzsakId > 0 && uzsakId < Uzsakymas.UzsakymuSarasas.Count)
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Console.WriteLine("Uzsakymo Id:" + uzsakId + ". Patiekalu sarasas:");
                        Uzsakymas.PrintPatikalusIsUzsakimo(Uzsakymas.SurastiUzsakymaPagalId(uzsakId));
                        Console.WriteLine("------------------------");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();      
                Console.WriteLine("Restorano uzsakymu valdymo programa 2024 Ver 0.1");
                Console.WriteLine("Paspauskite 1, kad prideti patiekala i meniu.");
                Console.WriteLine("Paspauskite 2, kad parodyti visus patiekalus.");
                Console.WriteLine("Paspauskite 3, kad prideti uzsakyma.");
                Console.WriteLine("Paspauskite 4, kad keisti patiekalo busena.");
                Console.WriteLine("Paspauskite 5, kad parodyti visus uzsakymus");
                Console.WriteLine("Paspauskite 6, kad parodyti konkretaus uzsakymo informacija.");
                Console.WriteLine("Paspauskite 7, kad iseiti is programos.");



                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                }
            }


        }

        
    }
}
