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
    class Program
    {
        static void Main(string[] args)
        {
            ember Pisti = new ember();
            ember Eva = new ember();

            Eva.nev = "Nagy Éva";
            Eva.eletkor = 18;

            Pisti.nev = "Nagy Pisti";
            Pisti.eletkor = 20;

            Pisti.eletkor++;


            System.Console.WriteLine(Pisti.bemutatkozas());
            System.Console.WriteLine(Eva.bemutatkozas());

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
