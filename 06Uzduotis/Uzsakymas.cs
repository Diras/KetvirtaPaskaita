using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Uzduotis
{
    internal class Uzsakymas
    {
        public int Id { get; set; }

        public string Klientas { get; set; }

        public List<Patiekalas> Patiekalai {  get; set; }

       

        public Uzsakymas()
        {
            Patiekalai = new List<Patiekalas>();
        }

        public Uzsakymas(int id, string klientas, List<Patiekalas> patiekalai)
        {
            Id = id;
            Klientas = klientas;
            Patiekalai = patiekalai;
        }

        public static List<Uzsakymas> UzsakymuSarasas = new List<Uzsakymas>();
        
        public static void PridetiPatiekala(Patiekalas patiekalas, int id)
        {
            SurastiUzsakymaPagalId(id).Patiekalai.Add(patiekalas);
        }

        public static Uzsakymas SurastiUzsakymaPagalId(int id)
        {
            Uzsakymas uzsakymas = new Uzsakymas();
            foreach (Uzsakymas item in UzsakymuSarasas)
            {
                if (item.Id == id)
                {
                    uzsakymas = item;
                }
            }

            return uzsakymas;
        }

        public static Patiekalas SurastiPatiekalaIsUzsakymoPagalId(Uzsakymas uzsakymas, int id)
        {
            Patiekalas patiekalas = new Patiekalas();
            foreach (Patiekalas item in uzsakymas.Patiekalai)
            {
                if (item.Id == id)
                {
                    patiekalas = item;
                }
            }

            return patiekalas;
        }

        public override string ToString()
        {
            return $"Id:{Id}, klientas {Klientas}, patiekalai: ";
        }

        public static void PrintSarasas()
        {
            foreach (Uzsakymas item in UzsakymuSarasas)
            {
                Console.WriteLine(item.ToString());
                PrintPatikalusIsUzsakimo(item);
                Console.WriteLine("------------------------");
            }
        }

        public static void PrintPatikalusIsUzsakimo(Uzsakymas uzsakymas)
        {
            foreach (Patiekalas item in uzsakymas.Patiekalai)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
