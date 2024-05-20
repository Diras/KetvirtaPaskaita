using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Uzduotis
{
    /*
     * Sukurkite klasę Knyga su šiais laukais:
                Id (int)
                Pavadinimas (string)
                Autorius (string)
                YraPaskolinta (bool)
     * */
    internal class Knyga
    {
        int Id { get; set; }
        string Pavadinimas { get; set; }
        string Autorius {  get; set; }
        bool YraPaskolinta { get; set; }

        public Knyga() 
        {
        
        }

        public Knyga(int id, string pavadinimas, string autorius, bool yraPaskolinta)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            YraPaskolinta = yraPaskolinta;
        }

        public bool PatikrintiArPaskolinta(Knyga knyga)
        {
            if (knyga.YraPaskolinta == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Paskolinimas(Knyga knyga)
        {
            knyga.YraPaskolinta = true;
        }
        public void Grazinimas(Knyga knyga)
        {
            knyga.YraPaskolinta = false;
        }

        public override string ToString()
        {
            return $"ID: {Id}, pavadinimas: {Pavadinimas}, autorius: {Autorius}, paskolinta: {YraPaskolinta}";
        }

        public int CheckId(Knyga knyga)
        {
            return knyga.Id;
        }

        public void ChangeId(Knyga knyga, int id)
        {
            knyga.Id = id;
        }
    }
}
