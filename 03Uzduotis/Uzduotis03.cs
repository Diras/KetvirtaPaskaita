
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Uzduotis03
    {
        public static void Main(string[] args)
        {
            /*Užduotis 1: Sąrašų Manipuliacija
                Aprašymas
                Sukurkite programą, kuri atliks šias užduotis su sąrašu:
                Sugeneruos sveikųjų skaičių sąrašą nuo 1 iki 100.
                Naudos ciklą, kad patikrintų kiekvieną skaičių ir išspausdins "Fizz", 
                jei skaičius dalijasi iš 3, "Buzz", jei dalijasi iš 5, ir "FizzBuzz", jei 
                dalijasi ir iš 3, ir iš 5. Jei nei viena iš šių sąlygų netinka, išspausdins patį skaičių.
             * */

            List<int> intList = new List<int>();
            Random random = new Random();

            int listSize = random.Next(1, 100);

            for (int i = 0; i < listSize; i++)
            {
                intList.Add(random.Next(0, 1001));
            }

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] % 3 == 0 && intList[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (intList[i] % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (intList[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(intList[i]);
                }
            }
        }


    }
}
