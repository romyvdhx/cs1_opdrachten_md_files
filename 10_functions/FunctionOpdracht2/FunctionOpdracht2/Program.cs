using System;

namespace FunctionOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program= new Program();
            int nummer = program.MijnFavorietNummer();//deze werkt nu niet, pas de code onder aan om het te laten werken

            Console.WriteLine($"mijn favoriet nummer {nummer}");
        }

        //laat deze function een 'int' teruggeven
        private int MijnFavorietNummer()
        {
            int mijnFavorieteNummer = 7;
            //maak hier een variable van het type 'int' en geef die een waarde
            return mijnFavorieteNummer;
            //geef hier de variable terug
        }

    }
}