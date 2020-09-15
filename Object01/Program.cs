using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class ember
    {
        public string nev;
        public int eletkor;
        public string bemutatkozas()
        {
            //string a = $"{nev} vagyok {eletkor} éves";
            //return a;

            //string a = nev + "vagyok" + eletkor + "éves";
            //return a;

            return $"{nev} vagyok, {eletkor} éves";
        }
    }

    class Teglalap
    {
        private int a;
        private int b;

        public Teglalap(int aoldal, int boldal)
        {
            a = aoldal;
            b = boldal;
        }

        //public string Terulet()
        //{
        //    return $"{a*b} a téglalap területe";
        //}
        //public string Kerulet()
        //{
        //    return $"{2 * (a + b)} a téglalap kerülete";
        //}
        public int Terulet()        //ha egész számot kér vissza a feladat
        {
            return a * b;
        }
        public int Kerulet()
        {
            return 2 * (a + b);
        }

    }

    class Kor
    {
        /*public*/private int r; //privát lesz, ha kivesszük előle a publicot, vagy odaírjuk elé a private-ot
        public Kor(int sugar)
        {
            if (sugar<1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
        }

        private double Kerulet()
        {
            return 2 * r * Math.PI;
        }
        private double Terulet()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public void adatok()
        {
            Console.WriteLine("Sugár: {0}", r);
            Console.WriteLine("Terület: {0}", Terulet());
            Console.WriteLine("Kerület {0}", Kerulet());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ember Pisti = new ember();
            //ember Eva = new ember();

            //Eva.nev = "Nagy Éva";
            //Eva.eletkor = 18;

            //Pisti.nev = "Nagy Pisti";
            //Pisti.eletkor = 20;

            //Pisti.eletkor++;


            //System.Console.WriteLine(Pisti.bemutatkozas());
            //System.Console.WriteLine(Eva.bemutatkozas());

            Console.WriteLine("\nTéglalap");
            Console.Write("Adja meg a téglalap A oldalát: ");
            int aoldal = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a téglalap B oldalát: ");
            int boldal = int.Parse(Console.ReadLine());
            Teglalap teeglalap = new Teglalap(aoldal, boldal);

            //teeglalap.a = 3;
            //teeglalap.b = 4;

            System.Console.WriteLine("Terület: {0}", teeglalap.Terulet());
            System.Console.WriteLine("Kerület: {0}", teeglalap.Kerulet());

            Console.WriteLine("\nKör");

            Console.Write("Írja be a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor korocske = new Kor(sugar);

            ////korocske.r = 15;

            //System.Console.WriteLine("Terület: {0}", korocske.Terulet());
            //System.Console.WriteLine("Kerület: {0}", korocske.Kerulet());
            korocske.adatok(); //ide már nem kell WriteLine

            Console.ReadKey();
        }
    }
}
