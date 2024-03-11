using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers
            controllersInMandje += 2;

            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5
            ps5++;

            //koop de games:

            int eldenRing = 0;
            eldenRing++;
            int shantae = 0;
            shantae++;
            int spongebob = 0;
            spongebob++;

            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            shantae--;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs
            double totaalGamePrijs = 0;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            totaalControllerPrijs = controllerPrijs * controllersInMandje;
            totaalGamePrijs = gamePrijs * (eldenRing + shantae + spongebob);

            double totaalPrijs = 0;// tel hier alles bij elkaar op
            totaalPrijs = ps5Prijs + totaalControllerPrijs + totaalGamePrijs;

            Console.WriteLine(totaalPrijs);
            //er moet nu 759.95 staan
        }
    }
}