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
        public int a;
        public int b;

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

            //Console.WriteLine();

            Teglalap teeglalap = new Teglalap();

            teeglalap.a = 3;
            teeglalap.b = 4;

            System.Console.WriteLine("Terület: {0}", teeglalap.Terulet());
            System.Console.WriteLine("Kerület: {0}", teeglalap.Kerulet());


            Console.ReadKey();
        }
    }
}
