using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassRoom
{
    class Program
    {
        private static void Main(string[] args)
        {
            Studerende Jannick = new Studerende("Jannick", 11, 21);
            Studerende Nikolai = new Studerende("Nikolai", 15, 01);

            KlasseRum minklasse = new KlasseRum(); //LAvet et objekt minklasse


            minklasse.KlasseNavn = "3B";
            minklasse.SemesterStart = new DateTime(2018, 4, 9);
            minklasse.KlasseListe.Add(Jannick);


            Console.WriteLine(Jannick.navn + " " + + Jannick.fødselsmåned + " " + Jannick.fødselsdag + " " 
                + minklasse.KlasseNavn + " " + minklasse.SemesterStart.ToString("yyyy-MM-dd"));

            Console.WriteLine(Nikolai.navn + " " + + Nikolai.fødselsmåned + " " + "" + Nikolai.fødselsdag + " "
                + minklasse.KlasseNavn + " " + minklasse.SemesterStart.ToString("yyyy-MM-dd"));

            Console.WriteLine(Nikolai.Seasons());

            Console.ReadLine();

        }
    }
}
