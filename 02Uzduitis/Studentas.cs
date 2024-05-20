using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis
{
    /*
     * Sukurkite klasę Studentas su šiais laukais: vardas (string), amzius (int), balas (double).
       Sukurkite metodą, kuris grąžina studento informaciją kaip string.
    */
    internal class Studentas
    {
        string Vardas {  get; set; }
        int Amzius { get; set; }
        double Balas { get; set; }


        public Studentas() 
        { 
        
        }

        public Studentas( string vardas, int amzius, double balas)
        {
            Vardas = vardas;
            Amzius = amzius;
            Balas = balas;
        }

        public static string PrintStudentas(Studentas stud )
        {

            string studentoInformacija;
            studentoInformacija = $"Vardas:{stud.Vardas}, amzius:{stud.Amzius}, balas:{stud.Balas}";
            return studentoInformacija;
        }
    }
}
