using System;

namespace PersonNummer
{
    class Program
    {

        static bool godkäntPersonNMR(string personNummer)
        {
            int summa1 = 0;
            int summa2 = 0;
            // Ersätter '-' så att det bara blir siffror
            personNummer = personNummer.Replace("-", ""); 
            // Kollar så att personnumret innehåller 10 siffror
            if (personNummer.Length != 10)
            {
                Console.WriteLine("Du måste ange ditt personnummer med 10 siffror, försök igen");
                return false;
            }
            // Tar varannat nummer med start från 1 och multiplicerar det med 2
            for (int i = 0; i < 10; i +=2)
            {
                // konverterar ett tecken till heltal
                int siffra1 = int.Parse(personNummer[i].ToString()); 
                int nummer1 = siffra1 * 2;
                if (nummer1 >= 10)
                {
                    // Dividerar första siffran om talet är större än 10
                    int förstaSiffra = nummer1 / 10;
                     // Får ut resten av talet nummer1 efter det har dividerats med 10
                    int andraSiffra = nummer1 % 10;
                    nummer1 = förstaSiffra + andraSiffra;
                }
                summa1 += nummer1;
            }
             // tar varannat nummer med start från 2 och multiplicerar det med 1
            for (int i = 1; i < 10; i +=2)
            {
                int siffra2 = int.Parse(personNummer[i].ToString());
                int nummer2 = siffra2 * 2;
                summa2 += nummer2;
            }
            summa2 += summa1;
            {
                // kollar så att summan är jämt delbart med 10
                if (summa2 % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return false;
        }
        static void Main(string[] arg)
        {
            string personNummer = "960322-4594";
            if (godkäntPersonNMR(personNummer))
            {
                Console.WriteLine("Detta är ett godkänt personnummer");
            }
            else
            {
                Console.WriteLine("Detta är inte ett godkänt personnummer");
            }
        }
    }
}


