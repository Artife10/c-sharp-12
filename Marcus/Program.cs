namespace Marcus
{
    internal class Program
    {
        public class Auto
        {
            public string Marka;
            public string Modell;
            public string Evjarat;
            public bool Berelheto;

            public Auto(string Marka, string Modell, string Evjarat, bool Berelheto)
            {
                this.Marka = Marka;
                this.Modell = Modell;
                this.Evjarat = Evjarat;
                this.Berelheto = Berelheto;
            }

            public void Kiir()
            {
                Console.WriteLine($"A kocsi márkája: {this.Marka}\nA kocsi modelle: {this.Modell}\nA kocsi évjárata {this.Evjarat}\nBérelhetősége: {this.Berelheto}");
            }

            public void BeallitBerelheto(bool ertek)
            {
                this.Berelheto = ertek;
                Console.WriteLine($"Mostantól a bérelhetőség: {ertek}");
            }

        }

        public class Diak
        {
            public string nev;
            public int evfolyam;
            public List<int> jegyek;

            public Diak(string nev, int evfolyam)
            {
                this.nev = nev;
                this.evfolyam = evfolyam;
                jegyek = new List<int>();
            }

            public void JegyHozzaad(int jegy)
            {
                this.jegyek.Add(jegy);
            }

            public double Atlag()
            {
                return this.jegyek.Average();
            }

        }

        public class Konyv
        {
            public string cim;
            public string szero;
            public double ar;

            public Konyv(string cim, string szero, double ar)
            {
                if (ar > 0) {
                    this.cim = cim;
                    this.szero = szero;
                    this.ar = ar;
                }
                else
                {
                    Console.WriteLine("Nem lehet az ár minusz");
                }
            }

            public void Kedvezmeny( double szazalek)
            {
                double egy = this.ar / 100;
                this.ar += egy*szazalek;
            }
        }

        class Termek
        {
            public string nev;
            public double ar;
            public int keszlet;

            public Termek(string nev, double ar, int keszlet)
            {
                this.nev = nev;
                this.ar = ar;
                this.keszlet = keszlet;
            }

            public void Vasarlas(int db)
            {
                if (this.keszlet > 0)
                {
                    this.keszlet -= db;
                }

            }

            public void Info()
            {
                Console.WriteLine($"Neve: {this.nev}\nÁra: {this.ar}\nKészlet: {this.keszlet}");
            }

        }

        public class Dolgozo
        {
            public string nev;
            public string beosztas;
            public double alap_fizetes;

            public Dolgozo(string nev, string beosztas, double alap_fizetes)
            {
                this.nev = nev;
                this.beosztas = beosztas;
                this.alap_fizetes = alap_fizetes;
            }

            public void FizetesEmeles(double szazalek)
            {
                double egy = this.alap_fizetes / 100;
                this.alap_fizetes += egy * szazalek;
            }

            public void TeljesFizetes()
            {
                Console.WriteLine($"Fizetése: {this.alap_fizetes}");
            }

        }

        public class Sportolo
        {
            public string nev;
            public string sportag;
            public List<int> eredmenyek;

            public Sportolo(string nev, string sportag)
            {
                this.nev = nev;
                this.sportag = sportag;
                this.eredmenyek = new List<int> { 0 };
            }

            public void EredmenyHozzaad(int pont)
            {
                eredmenyek.Add(pont);
            }

            public void LegjobbEredmeny()
            {
                Console.WriteLine(eredmenyek.Max());
            }
        }

        public class Osztaly
        {
            public List<string> tanulok;

            public Osztaly()
            {
                tanulok = new List<string>();
            }

            public void Hozzaad(string nev)
            {
                tanulok.Add(nev);
            }

            public void LetezikE(string nev)
            {
                for (int i = 0; i < tanulok.Count(); i++)
                {
                    string tanulo = tanulok[i];
                    if (tanulo == nev)
                    {
                        Console.WriteLine("Létezik");
                    }
                    else
                    {
                        Console.WriteLine("Nem létezik");
                    }
                }
            }
            
            public int Letszam()
            {
                return tanulok.Count();
            }
        }

        public class Film
        {
            public string cim { get; set; }
            public string rendezo { get; set; }
            public double ertekeles;

            public void SetErtekeles(double ertekeles)
            {
                if (ertekeles > 0 && ertekeles <= 10)
                {
                    this.ertekeles = ertekeles;
                }
                else
                {
                    Console.WriteLine("Nem lehetséges az értékelésed tesa");
                }

            }

            public void Leiras()
            {
                Console.WriteLine($"Cím: {this.cim}\nRendezo: {this.rendezo}\nÉrtékelés: {this.ertekeles}");
            }


        }


        public class Tanfolyam
        {
            public string Nev;
            public string Oktato;
            public List<string> Resztvevok;

            public Tanfolyam(string nev, string oktato, List<string> resztvevok)
            {
                Nev = nev;
                Oktato = oktato;
                Resztvevok = new List<string>();
            }

            public void ResztvevoHozzaad(string nev)
            {
                Resztvevok.Add(nev);
            }
            public int ResztvevoSzam()
            {
                return Resztvevok.Count();
            }
            public void Keres(string nev)
            {
                Console.WriteLine(Resztvevok.Find(x => x == nev));
            }
        }

        public class Allat
        {
            public string nev;
            public string faj;
            public int eletkor;

            public Allat(string nev, string faj, int eletkor)
            {
                this.nev = nev;
                this.faj = faj;
                this.eletkor = eletkor;
            }

            public void SetEv(int ev)
            {
                if (ev > 0)
                {
                    this.eletkor = ev;
                }
            }

            public void Oregszik()
            {
                this.eletkor++;
            }


        }

        public class Karakter
        {
            public string nev;
            public double hp;
            public double xp;

            public Karakter(string nev, double hp, double xp)
            {
                if (hp > 0 && 0 <= 100)
                {
                    this.nev = nev;
                    this.hp = hp;
                    this.xp = xp;
                }

            }

            public void SebzestKap(int dmg)
            {
                hp -= dmg;
            }

            public void Gyogyultam(int hp)
            {
                hp += hp;
            }

            public void Szintlepes()
            {
                if (xp > 10)
                {
                    xp = 0;
                    Console.WriteLine("Szintlepes");
                }
            }

        }

        public class Idopont
        {
            public string datum;
            public bool foglalt;

            public Idopont(string datum, bool foglalt)
            {
                this.datum = datum;
                this.foglalt = foglalt;
            }

            public void Foglal()
            {
                foglalt = true;
            }

            public void Lemond()
            {
                foglalt = false;
            }
        }

        public class Rendeles
        {
            public int asztalszam;
            public List<string> tetelek;

            public Rendeles(int asztalszam, List<string> tetelek)
            {
                this.asztalszam = asztalszam;
                this.tetelek = tetelek;
            }

            public void HozzaadTetel(string t)
            {
                tetelek.Add(t);
            }
            public int Tetelekszama()
            {
                return tetelek.Count();
            }

            public void Megjelenit()
            {
                foreach (var item in tetelek)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public class Homero
        {
            public double homerseklet;

            public void SetHomer(double homerseklet)
            {
                if (homerseklet > -50 && homerseklet < 50)
                {
                    this.homerseklet = homerseklet;
                }
                
            }

            public void Leiras()
            {
                Console.WriteLine(homerseklet);
            }
            public bool Veszelyese()
            {
                if (homerseklet > 50 || homerseklet < -25)
                {
                    return true;
                }
                else
                {
                    return false
                }
            }

        }

        static void Main(string[] args)
        {
            Random rng = new Random();
            var kocs = new Auto("Suzuki", "Röfögős", "1879", false);

            kocs.Kiir();
            kocs.BeallitBerelheto(true);

            Console.WriteLine();
            Console.WriteLine();

            var deak = new Diak("Elem",12);

            for (int i = 0; i < 10; i++) {
                deak.JegyHozzaad(rng.Next(5));
            }

            Console.WriteLine($"A diák átlaga: {deak.Atlag()}");
            // Valamiért mindig megbukik de random :3

            Console.WriteLine();
            Console.WriteLine();

            var koynv = new Konyv("Rókák a pincémben", "Zsedákiás Ákos", 1200);

            Console.WriteLine(koynv.ar);
            koynv.Kedvezmeny(-10);
            Console.WriteLine(koynv.ar);

            Console.WriteLine();
            Console.WriteLine();

            var pityoka = new Termek("Krupli", 245, 13);

            pityoka.Info();
            pityoka.Vasarlas(6);
            pityoka.Info();

            Console.WriteLine();
            Console.WriteLine();



        }
    }
}
