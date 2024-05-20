using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis01
    {
        public static void Main(string[] args)
        {
            /*Užduotis 1: Sąrašų Manipuliacija
                Aprašymas
                Sukurkite programą, kuri atliks šias užduotis su sąrašu:
                Sukurs sąrašą, kuriame yra šie sveikieji skaičiai: 5, 3, 8, 4, 2.
                Išspausdins sąrašo elementus.
                Pridės skaičių 10 į sąrašo pabaigą.
                Ištrins skaičių 4 iš sąrašo.
                Rūšiuos sąrašą didėjančia tvarka.
                Išspausdins sąrašą po kiekvieno pakeitimo.
             * */

            List<int> intList = new List<int> {5, 3, 8, 4, 2};
            Print(intList);

            intList.Add(10);
            Print(intList);

            intList.Remove(4);
            Print(intList);

            intList.Sort();
            Print(intList);



        }

        public static void Print(List<int> intList)
        {
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
