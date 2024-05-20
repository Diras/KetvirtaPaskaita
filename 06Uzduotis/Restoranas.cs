using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Uzduotis
{
    internal class Restoranas
    {
        public static List<Patiekalas> Meniu = new List<Patiekalas>();

        public static void PridetiPatiekalaIMeniu(Patiekalas patiekalas) 
        {
            Meniu.Add(patiekalas);
        }

        public static void RodytiVisusPatiekalus()
        {
            foreach (Patiekalas patiekalas in Meniu)
            {
                Console.WriteLine(patiekalas.ToString());
            }
        }

        public static void PridetiUzsakyma(Uzsakymas uzsakymas)
        {
            Uzsakymas.UzsakymuSarasas.Add(uzsakymas);
        }

        public static void KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena)
        {
            Uzsakymas.SurastiPatiekalaIsUzsakymoPagalId(Uzsakymas.SurastiUzsakymaPagalId(uzsakymoId), patiekaloId).Busena = naujaBusena;
            
        }

        public static void RodytiVisusUzsakymus()
        {

        }

        public static void RodytiUzsakyma(int uzsakymoId)
        {

        }


        public static Patiekalas SurastiPatiekalaPagalId(int id) 
        {
            Patiekalas patiekalas = new Patiekalas();
            foreach (Patiekalas item in Meniu)
            {
                if(item.Id == id)
                {
                    patiekalas = item;
                }
            }

            return patiekalas;
        }
    }
}
