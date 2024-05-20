
using _04Uzduotis;
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis04
    {
        public static void Main(string[] args)
        {
            /*Užduotis 1: Sąrašų Manipuliacija
                Aprašymas
                Sukurkite programą, kuri atliks šias užduotis su sąrašu:
                Sukurkite klasę Studentas su šiais laukais: vardas (string),
                    pavarde (string), amzius (int), balai int masyvas, vidurkis double.
                Sukurkite meniu (1. Sukurti studenta (ivesti 5 balus), 2. Istrinti studenta, 3. Isvesti studentus i ekrana)
                Klasėje Studentas sukurkite funkciją kuri skaičiuoja studento vidurkį
                Prieš išvedant studentą į ekraną, visada iškviesti šią funkciją, 
                    kad ji suskaičiuotų studento vidurkį. (Override'e ToString)
             * */

            List<Studentas> list = new List<Studentas>();
            


            Console.WriteLine("Studentu valdymo programa 2024 Ver 0.1");
            Console.WriteLine("Paspauskite 1, kad prideti studenta.");
            Console.WriteLine("Paspauskite 2, kad istrinti studenta.");
            Console.WriteLine("Paspauskite 3, kad pamatyti studentu sarasa.");
            Console.WriteLine("Paspauskite 4, kad isjungti programa.");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
            }

            while (number != 4)
            {
                

                switch (number)
                {
                    case 1:

                        Console.WriteLine("Studento ivedimas...");
                        Console.WriteLine("Iveskite varda...");
                        string vardas = Console.ReadLine();
                        Console.WriteLine("Iveskite pavarde...");
                        string pavarde = Console.ReadLine();
                        Console.WriteLine("Iveskite amziu...");
                        int amzius;
                        while (!int.TryParse(Console.ReadLine(), out amzius))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        Console.WriteLine("Iveskite kiek pazymiu norite ivesti studentui...");

                        int pazymiuSkaicius;
                        while (!int.TryParse(Console.ReadLine(), out pazymiuSkaicius))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }

                        int[] balai = new int[pazymiuSkaicius];

                        for (int i = 0; i < balai.Length; i++)
                        {
                            Console.WriteLine($"Iveskite {i+1} bala...");

                            int skaicius;
                            while (!int.TryParse(Console.ReadLine(), out skaicius))
                            {
                                Console.WriteLine("Neteisingas skaicius, pabandykite dar karta! Iveskite nuo 1 iki 10");
                            }

                            balai[i] = skaicius;

                            if(skaicius <1 || skaicius > 10)
                            {
                                i--;
                                Console.WriteLine("Neteisingas skaicius, pabandykite dar karta! Iveskite nuo 1 iki 10");
                            }
                        }


                        list.Add(new Studentas(vardas, pavarde, amzius, balai));
                        Console.WriteLine("Studentas pridetas");



                        break;

                    case 2:
                        Console.WriteLine("Pasirinkote studento pasalinima is saraso.");
                        Console.WriteLine("Iveskite studento numeri is saraso kuri norite pasalinti...");
                        int numeris;
                        while (!int.TryParse(Console.ReadLine(), out numeris))
                        {
                            Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                        }
                        if(numeris < list.Count || numeris > list.Count)
                        {
                            Console.WriteLine("Tokio studento sarase nera, pradekite is naujo!");
                        }
                        else
                        {
                            list.RemoveAt(numeris-1);
                            Console.WriteLine("Studentas pasalintas");
                        }
                        break;
                        case 3:
                        foreach (var student in list)
                        {
                            Studentas.Average(student);
                            Console.WriteLine(student.ToString());
                        }

                        break;
                    default:
                        break;
                }


                Console.WriteLine("Studentu valdymo programa 2024 Ver 0.1");
                Console.WriteLine("Paspauskite 1, kad prideti studenta.");
                Console.WriteLine("Paspauskite 2, kad istrinti studenta.");
                Console.WriteLine("Paspauskite 3, kad pamatyti studentu sarasa.");
                Console.WriteLine("Paspauskite 4, kad isjungti programa.");

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Neteisingas skaicius, pabandykite dar karta!");
                }
            }
            
        }


    }
}
