using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classos
{
    internal class Program
    {
        class Diak
        {
            private string nev;
            private int kor;
            private string iskola;


            public void SetNev(string nev)
            {
                this.nev = nev;
            }

            public string GetNev()
            {
                return nev;
            }



            public void SetKor(int kor)
            {
                this.kor = kor;
            }

            public int GetKor()
            {
                return kor;
            }



            public void SetIskola(string iskola)
            {
                this.iskola = iskola;
            }

            public string GetIskola()
            {
                return iskola;
            }
        }

        static void Main(string[] args)
        {
            /*
            Diak tobias = new Diak();


            tobias.SetNev("Tégladobó Tóbiás");
            tobias.SetKor(19);
            tobias.SetIskola("Tégladobó Egyetem");

            Console.WriteLine("Tóbiás teljes neve: ");
            Console.WriteLine(tobias.GetNev());
            Console.WriteLine();

            Console.WriteLine("Tóbiás kora: ");
            Console.WriteLine(tobias.GetKor());
            Console.WriteLine();

            Console.WriteLine("Tóbiás ide jár: ");
            Console.WriteLine(tobias.GetIskola());
            Console.WriteLine();
            List<Diak> diakok = new List<Diak>();

            string[] keresztnevek = {"Alex", "Ágnes", "Tóbiás", "Alexander", "Benjamin","Dominik","Mira","Bandi","Nándi","Náder"};
            string[] csaladnevek = { "Repegős", "Jámbor", "Tégladobó", "Karcos", "Bendő", "Nagyotbaszó", "Kovács", "Öblös","Akna" };

            Random rng = new Random();

            for (int i = 0; i < 200; i++)
            {
                Diak deak = new Diak();
                deak.SetNev(csaladnevek[rng.Next(csaladnevek.Length - 1)]+" "+keresztnevek[rng.Next(keresztnevek.Length-1)]);
                deak.SetKor(16 + rng.Next(5));
                deak.SetIskola("HSZC Pollák Antal Technikum");
                diakok.Add(deak);
            }

            Console.WriteLine("NÉV   |    KOR    |   ISKOLA");

            foreach (var d in diakok)
            {
                Console.WriteLine(d.GetNev()+" || "+d.GetKor().ToString()+" || "+ d.GetIskola());
                Console.WriteLine();
            }*/

            Diak bekert = new Diak();

            Console.WriteLine("Kérem a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Kérem a korod: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az iskolád: ");
            string suli = Console.ReadLine();

            bekert.SetNev(nev);
            bekert.SetKor(kor);
            bekert.SetIskola(suli);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Neved: "+bekert.GetNev());
            Console.WriteLine("Korod: " + bekert.GetKor().ToString());
            Console.WriteLine("Iskolád: " + bekert.GetIskola());


        }
    }
}
