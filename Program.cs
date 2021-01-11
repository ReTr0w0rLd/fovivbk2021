


using System;
using System.IO;
using System.Linq;

namespace focivbk2021
{
    class Program
    {
        struct orszagok
        {
            public string ország;
            public string részvétel;
            public string legelső;
            public string legutóbbi;
            public string legjobb;
        }
        static orszagok[] orszag = new orszagok[80];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("focivbk2021.txt");
            int sorokszama = 0;
            for (int k = 1; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                orszag[sorokszama].ország = egysordarabolva[0];
                orszag[sorokszama].részvétel = egysordarabolva[1];
                orszag[sorokszama].legelső = egysordarabolva[2];
                orszag[sorokszama].legutóbbi = egysordarabolva[3];
                orszag[sorokszama].legjobb = egysordarabolva[4];

                sorokszama++;
            }

            Console.WriteLine("Versenysorozat a fájlból");
            int orszagokszama = sorokszama;
            Console.WriteLine("Ország                   Részvételek száma                   Legelső részvétel                   Legutóbbi részvétel                 Legjobb részvétel");
            for (int i = 0; i < orszagokszama; i++);

            Console.WriteLine(" ");
            Console.WriteLine("1. feladat");
            Console.WriteLine(" ");
            int[] tomb = { };
            
        }
    }
}

