using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Uzduotis
{
    /*
     * Sukurkite klasę Biblioteka, kuri turės metodus:
                PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
                SalintiKnyga(int id): Pašalina knygą pagal ID.
                PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
                GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
                RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
                RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.
     * */
    internal class Biblioteka
    {
        public static List<Knyga> biblioteka = new List<Knyga>();


        public void PridetiKnyga(Knyga knyga)
        {
            biblioteka.Add(knyga);
        }

        public static void SalintiKnyga(int id)
        {
            int idForDelete = 0;
            foreach (Knyga book in biblioteka)
            {
                if (book.CheckId(book) == id)
                {
                    biblioteka.Remove(book);
                    idForDelete = book.CheckId(book);
                    break;
                }
            }
            if (idForDelete > 0) 
            {
                for (int i = idForDelete-1; i < biblioteka.Count; i++)
                {
                    biblioteka[i].ChangeId(biblioteka[i], i+1);
                }
            }
        }

        public static void PaskolintiKnyga(int id)
        {
            foreach (Knyga book in biblioteka)
            {
                if (book.CheckId(book) == id)
                {
                    if (book.PatikrintiArPaskolinta(book))
                    {
                        Console.WriteLine("Knygos nera, siuo metu paskolinta");
                    }
                    else
                    {
                        book.Paskolinimas(book);
                        Console.WriteLine("Jus gavote knyga!");
                    }
                }
            }
            
            
        }
        public static void GrazintiKnyga(int id)
        {
            foreach (Knyga book in biblioteka)
            {
                if (book.CheckId(book) == id)
                {
                    if (book.PatikrintiArPaskolinta(book))
                    {
                        book.Grazinimas(book);
                        Console.WriteLine("Knyga grazinta");
                    }
                    else
                    {
                        Console.WriteLine("Knyga nebuvo paimta");
                    }
                }
            }
        }

        public static void ShowAllBooks()
        {
            foreach (Knyga book in biblioteka)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public static void ParodytiPaskolintasKnygas()
        {
            int count = 0;
            foreach (Knyga book in biblioteka)
            {
                if (book.PatikrintiArPaskolinta(book))
                {
                    Console.WriteLine(book.ToString());
                    count++;
                }
                
            }

            if (count == 0)
            {
                Console.WriteLine("Paskolintu knygu nera!");
            }

                
        }
    }
}
