using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Uzduotis
{
    /*  Sukurkite klasę Studentas su šiais laukais: vardas (string),
            pavarde (string), amzius (int), balai int masyvas, vidurkis double.
        Sukurkite meniu (1. Sukurti studenta, 2. Istrinti studenta, 3. Isvesti studentus i ekrana)
        Klasėje Studentas sukurkite funkciją kuri skaičiuoja studento vidurkį
        Prieš išvedant studentą į ekraną, visada iškviesti šią funkciją, 
            kad ji suskaičiuotų studento vidurkį. (Override'e ToString)
    */
    internal class Studentas
    {
        string Vardas {  get; set; }
        string Pavarde { get; set; }
        int Amzius { get; set; }
        int[] Balai { get; set; }
        double Vidurkis { get; set; }


        public Studentas()
        {

        }

        public Studentas(string vardas, string pavade, int amzius, int[] balai)
        {
            Vardas = vardas;
            Pavarde = pavade;
            Amzius = amzius;
            Balai = balai;
        }


        public static void Average(Studentas studentas)
        {
            
            double sum = 0;
            foreach (var balas in studentas.Balai)
            {
                sum += balas;
            }
            studentas.Vidurkis = sum / studentas.Balai.Length;
        }


        public override string ToString()
        {

            return Vardas + " " + Pavarde + " " + Amzius + " (amzius), balu vidurkis: " + Vidurkis;
        }
    }
}
