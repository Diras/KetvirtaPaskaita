using _02Uzduotis;
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis02
    {
        public static void Main(string[] args)
        {
            /*Užduotis 1: Sąrašų Manipuliacija
                Aprašymas
                Sukurkite programą, kuri atliks šias užduotis su sąrašu:
                Sukurkite klasę Studentas su šiais laukais: vardas (string), amzius (int), balas (double).
                Sukurkite metodą, kuris grąžina studento informaciją kaip string.
                Sukurkite kelis studentų objektus ir pridėkite juos į sąrašą.
                Išspausdinkite visų studentų informaciją.
             * */

            Studentas studentas1 = new Studentas("Ernestas", 34, 9.5 );
            Studentas studentas2 = new Studentas("Vardenis", 30, 8);
            Studentas studentas3 = new Studentas("Pavardenis", 25, 7.5);

            List<Studentas> studentuSarasas = new List<Studentas>();

            studentuSarasas.Add(studentas1);
            studentuSarasas.Add(studentas2);
            studentuSarasas.Add(studentas3);

            foreach (var studentas in studentuSarasas)
            {
                Console.WriteLine(Studentas.PrintStudentas(studentas));
            }
            

        }

       
    }
}
