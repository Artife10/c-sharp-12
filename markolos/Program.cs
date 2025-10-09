using System;
using System.Collections.Generic;

namespace OsztalyScopeGyakorlas
{
    // ==========================
    // 🔹 ALAP PÉLDA
    // ==========================
    // Készíts egy "Diak" osztályt:
    // - publikus "Nev" mező (string)
    // - privát "kor" mező (int)
    // - publikus metódus "BeallitKor(int ujKor)"
    // - publikus metódus "Kiir()" → írja ki a nevet és kort
    public class Diak
    {
        public string Nev { get; set; }
        private int kor;
        
        public void BeallitKor(int kor)
        {
            this.kor = kor;
        }

        public void Kiir()
        {
            Console.WriteLine($"Név: {Nev} \nKor {kor}");
        }

    }

    // ==========================
    // 🔹 1. FELADAT: Kutya osztály
    // ==========================
    // Készíts egy "Kutya" osztályt:
    // - publikus "Nev" property
    // - privát "eletkor" mező
    // - metódus: "BeallitEletkor(int kor)" → ne engedjen negatív értéket
    // - metódus: "Kiir()" → írja ki a kutya nevét és életkorát
    public class Kutya
    {
        public string Nev {  set; get; }
        private int eletkor;

        public void BeallitEletkor(int kor)
        {
            this.eletkor = kor;
        }

        public void Kiir()
        {
            Console.WriteLine($"Név: {Nev} \nKor {eletkor}"); ;
        }

    }

    // ==========================
    // 🔹 2. FELADAT: BankSzamla osztály
    // ==========================
    // Készíts egy "BankSzamla" osztályt:
    // - privát "egyenleg" mező (int)
    // - metódus: "PenzBetesz(int osszeg)" → csak pozitív összeget fogadjon el
    // - metódus: "PenzKivesz(int osszeg)" → csak ha van elég pénz
    // - metódus: "EgyenlegKiir()" → írja ki az aktuális egyenleget
    public class BankSzamla
    {
        private int egyenleg;

        public void PenzBetesz(int osszeg)
        {
            if (osszeg >= 0)
            {
                this.egyenleg += osszeg;
                Console.WriteLine("Sikeres");
            }
            else
            {
                Console.WriteLine("Kérem pozitív számot adjon meg");
            }
        }

        public void PenzKivesz(int osszeg)
        {
            if (this.egyenleg - osszeg >= 0)
            {
                this.egyenleg -= osszeg;
                Console.WriteLine("Sikeres");
            }
            else
            {
                Console.WriteLine("Nincs elég pénze");
            }
        }

        public void EgyenlegKiir()
        {
            Console.WriteLine($"Az aktuális egyenlege: {this.egyenleg}");
        }

    }

    // ==========================
    // 🔹 3. FELADAT: Szamlalo osztály
    // ==========================
    // Készíts egy "Szamlalo" osztályt:
    // - privát "ertek" mező (int)
    // - metódus: "Novel()" → növelje 1-gyel az értéket
    // - metódus: "Nullaz()" → állítsa vissza 0-ra
    // - metódus: "Kiir()" → írja ki az aktuális értéket
    public class Szamlalo
    {
        private int ertek;

        public void Novel()
        {
            this.ertek += 1;
            Console.WriteLine("1 hozzáadva");
        }

        public void Nullaz()
        {
            this.ertek = 0;
            Console.WriteLine("Lenullázva");
        }

        public void Kiir()
        {
            Console.WriteLine($"Az érték{this.ertek}");
        }

    }

    // ==========================
    // 🔹 4. FELADAT: Tanulo osztály
    // ==========================
    // Készíts egy "Tanulo" osztályt:
    // - publikus "Nev" property
    // - privát "jegyek" lista (List<int>)
    // - metódus: "JegyHozzaad(int jegy)" → csak 1–5 közötti értéket fogadjon el
    // - metódus: "AtlagSzamit()" → számolja ki az átlagot
    // - metódus: "Kiir()" → írja ki a nevet, jegyeket és átlagot
    public class Tanulo
    {
        public string Nev { get; set; }
        private List<int> jegyek = new List<int> { };

        public void JegyHozzaad(int jegy)
        {
            if (jegy > 0 && jegy < 6)
            {
                jegyek.Add(jegy);
                Console.WriteLine($"Jegy hozzáadva");
            }
            else
            {
                Console.WriteLine("Kérem adjon meg egy érvényes jegyet");
            }
        }

        public void AtlagSzamit()
        {
            double atlag = jegyek.Sum()/jegyek.Count();
            Console.WriteLine($"A diák átlaga {atlag}");
        }

        public void Kiir()
        {
            double atlag = Convert.ToDouble(jegyek.Sum()) / Convert.ToDouble(jegyek.Count());

            Console.WriteLine($"Nev: {this.Nev}");
            Console.WriteLine("Jegyei: ");

            for (int i = 0; i < jegyek.Count(); i++)
            {
                Console.Write(jegyek[i] + " ");
            }

            Console.WriteLine($"\nA diák átlaga {atlag}");

        }
    }

    // ==========================
    // 🔹 MAIN PROGRAM
    // ==========================
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ALAP PÉLDA ===");
            Console.WriteLine("Készíts egy Diak osztályt és próbáld ki a mezők és metódusok működését!");
            Console.WriteLine();

            Diak Reneged = new Diak();
            Reneged.Nev = "Pataki Renegéd";
            Reneged.BeallitKor(21);
            Reneged.Kiir();

            Console.WriteLine();
            Console.WriteLine("\n=== 1. FELADAT: Kutya ===");
            Console.WriteLine("Hozz létre egy kutya objektumot, állíts be adatokat és írasd ki!");
            Console.WriteLine();

            Kutya besenyo = new Kutya();
            besenyo.Nev = "Besenyő";
            besenyo.BeallitEletkor(12);
            besenyo.Kiir();



            Console.WriteLine();
            Console.WriteLine("\n=== 2. FELADAT: BankSzamla ===");
            Console.WriteLine("Teszteld a befizetés és kifizetés metódusokat különböző értékekkel!");
            Console.WriteLine();
            BankSzamla bankSzamla = new BankSzamla();

            bankSzamla.PenzBetesz(500);
            bankSzamla.PenzKivesz(300);

            bankSzamla.PenzBetesz(-500);
            bankSzamla.PenzKivesz(10000);
            bankSzamla.EgyenlegKiir();

            Console.WriteLine();
            Console.WriteLine("\n=== 3. FELADAT: Szamlalo ===");
            Console.WriteLine("Próbáld ki a növelés és nullázás metódusokat!");
            Console.WriteLine();

            Szamlalo szamlalo = new Szamlalo();
            szamlalo.Novel();
            szamlalo.Kiir();
            szamlalo.Nullaz();
            szamlalo.Kiir();

            Console.WriteLine();
            Console.WriteLine("\n=== 4. FELADAT: Tanulo ===");
            Console.WriteLine("Adj hozzá jegyeket, majd írasd ki a tanuló átlagát!");

            Tanulo bandita = new Tanulo();
            bandita.Nev = "Hegedűs Bandita";

            Random rng = new Random();

            for (int i = 0; i < 12; i++)
            {
                int randomnum = rng.Next(7);
                bandita.JegyHozzaad(randomnum);
            }

            bandita.AtlagSzamit();
            bandita.Kiir();


        }
    }
}