using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace wawa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. FELADAT
            Console.WriteLine("1. FELADAT ---------");

            double[] szamok = new double[5];


            Console.WriteLine("Irj be 5 szamot: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                double szam = Convert.ToDouble(Console.ReadLine());
                szamok.SetValue(szam, i);
                Console.WriteLine();
            }

            Console.Write("Az összeg: ");
            Console.Write(szamok.Sum());
            Console.WriteLine();

            //---------------------------
            //2. FELADAT
            Console.WriteLine("2. FELADAT ---------");

            Random rng = new Random();
            int[] randomok = new int[10];

            for (int i = 0; i < randomok.Length; i++)
            {
                int rand = rng.Next(1000);
                randomok[i] = rand;
            }
            Console.WriteLine("A számok: ");

            for (int i = 0; i < randomok.Length; i++)
            {
                Console.Write(randomok[i].ToString()+" ");
            }
            Console.WriteLine();

            int max = randomok.Max();
            int min = randomok.Min();
 
            Console.WriteLine("Legkisebb: " + min.ToString());
            Console.WriteLine("Legnagyobb: " + max.ToString());

            //addig szamokat amig nem nulla tombbe ko

            //---------------------------
            //3. FELADAT
            Console.WriteLine("3. FELADAT ---------");
            Console.WriteLine("Adj meg szamokat:");
            List<int> szamos = new List<int>();

            while (true)
            {
                int beker = Convert.ToInt32(Console.ReadLine());

                if (beker != 0)
                {
                    szamos.Add(beker);
                }
                else
                {
                    Console.WriteLine("Ezeket adtad meg: ");
                    for (int i = 0; i < szamos.Count; i++)
                    {
                        Console.Write(szamos[i].ToString()+" ");
                        
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ennyit adtál meg: "+szamos.Count.ToString());
                    break;
                }
            }


            //4. FELADAT
            Console.WriteLine("4. FELADAT ---------");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int d = 0; d < i; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


        }
    }
}
