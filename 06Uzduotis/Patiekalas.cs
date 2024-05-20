using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Uzduotis
{
    internal class Patiekalas
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }

        public double Kaina { get; set; }   

        public string Busena { get; set; }  


        public Patiekalas() 
        {
        
        }

        public Patiekalas(int id, string pavadinimas, double kaina)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }

        public Patiekalas(int id, string pavadinimas, double kaina, string busena)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Busena = busena;
        }

        public override string ToString()
        {
            return $"Id:{Id}, pavadinimas {Pavadinimas}, kaina: {Kaina}, busena {Busena}";
        }
    }
}
