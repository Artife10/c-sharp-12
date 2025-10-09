using System;

namespace ErtekSzerintiAtadas_Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Érték szerinti átadás – gyakorlófeladatok ===");
            Console.WriteLine();
            int szam1 = 4;

            Feladat1(4);

            Console.WriteLine();
            int szam2 = 4;
            Feladat2(szam2);

            Console.WriteLine();
            int szam3 = 4;
            Feladat3(szam3);
            Console.WriteLine();

            int szam4 = 6;
            int szam5 = 3;
            Feladat4(szam4, szam5);

            Console.WriteLine();

            int szam6 = 34;
            Feladat5(szam6);
            Console.WriteLine("semmi woooow mert a paramétert állítja");

            Console.WriteLine();
            int szam7 = 24;
            int szam8 = Feladat6(szam7);
            Console.WriteLine(szam8);

            Console.WriteLine();

            int szam9 = 21;
            double szam10 = Feladat7(szam9);
            Console.WriteLine(szam10);

            Console.WriteLine();
            Feladat8(5);
            Console.WriteLine();

            // Itt hívd meg majd a saját függvényeidet, ha megoldottad a feladatokat.
            // Példa: Feladat1();
        }

        /*
        * 1. FELADAT:
        * Készíts egy függvényt, ami egy egész számot kap,
        * és kiírja annak a kétszeresét.
        * A Main-ben hívd meg úgy, hogy a függvényhívás után
        * az eredeti változó ne változzon meg!
        */

        // static void Feladat1(int szam) { ... }

        static void Feladat1(int szam)
        {
            Console.WriteLine(szam * 2);
        }


        /*
        * 2. FELADAT:
        * Készíts függvényt, ami egy számot kap és 1-gyel növeli.
        * Írd ki az értéket a függvényben és a Main-ben is!
        * Figyeld meg, hogy a Main-ben az érték nem változik.
        */

        // static void Feladat2(int szam) { ... }

        static void Feladat2(int szam)
        {
            Console.WriteLine(szam + 1);
        }

        /*
        * 3. FELADAT:
        * Írj függvényt, ami megszoroz egy számot 3-mal,
        * és visszaadja az új értéket!
        * A Main-ben a visszatérési értéket tárold el az eredeti változóba,
        * így az meg fog változni.
        */

        // static int Feladat3(int szam) { ... }

        static int Feladat3(int szam)
        {
            return szam * 3;
        }

        /*
        * 4. FELADAT:
        * Írj függvényt, ami két egész számot kap,
        * és mindkettőt 1-gyel növeli.
        * A függvényben írd ki az új értékeket,
        * de figyeld meg, hogy a Main-ben nem változnak.
        */

        // static void Feladat4(int x, int y) { ... }
        static void Feladat4(int x, int y)
        {
            Console.WriteLine(x+1);
            Console.Write(y+1);
        }

        /*
        * 5. FELADAT:
        * Írj függvényt, ami próbálja 0-ra állítani a paraméterként kapott számot.
        * A Main-ben ellenőrizd, hogy az érték változott-e (nem fog).
        */

        // static void Feladat5(int szam) { ... }

        static void Feladat5(int szam)
        {
            szam = 0;
        }

        /*
        * 6. FELADAT:
        * Írj függvényt, ami egy számot növel 5-tel és visszaadja az új értéket.
        * A Main-ben a visszatérési értéket tárold vissza a változóba.
        * Ez mutatja meg, hogy így lehet "megváltoztatni" az értéket érték szerinti átadásnál.
        */

        // static int Feladat6(int szam) { ... }
        static int Feladat6(int szam)
        {
            return szam + 5;
        }

        /*
        * 7. FELADAT:
        * Készíts függvényt, ami egy hőmérsékletet (int) kap Celsiusban,
        * és kiszámolja Fahrenheitbe (képlet: F = C * 1.8 + 32),
        * majd visszaadja az új értéket.
        * A Main-ben írd ki az eredményt, és ellenőrizd, hogy az eredeti változó megmaradt.
        */

        // static double Feladat7(int celsius) { ... }

        static double Feladat7(int celsius)
        {
            return celsius * 1.8 + 32;
        }


        /*
        * 8. FELADAT (extra):
        * Készíts függvényt, ami kap egy számot,
        * és megpróbálja módosítani azt a függvényen belül többször (pl. *2, +10),
        * majd írd ki a függvényben és a Main-ben is az értéket.
        * Írd le kommentben a tapasztalatodat:
        * Miért nem változott meg az eredeti változó?
        */

        // static void Feladat8(int szam) { ... }

        static void Feladat8(int szam)
        {
            szam += 8;
            szam -= 3;
            szam += 42;
            Console.WriteLine(szam);
        }

    }
}