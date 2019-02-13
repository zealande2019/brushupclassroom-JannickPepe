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
            Studerende Nikolai = new Studerende("Nikolai", 1, 15);

            KlasseRum minklasse = new KlasseRum(); //LAvet et objekt minklasse


            minklasse.KlasseNavn = "3B";
            minklasse.SemesterStart = new DateTime(2018, 4, 9);
            minklasse.KlasseListe.Add(Jannick);
            minklasse.KlasseListe.Add(Nikolai);

            Console.WriteLine(Jannick.navn + " " + + Jannick.fødselsmåned + " " + Jannick.fødselsdag + " " 
                + minklasse.KlasseNavn + " " + minklasse.SemesterStart.ToString("yyyy-MM-dd") + " " + "født i sæsonen" + " " + 
                Jannick.Seasons());

            Console.WriteLine(Nikolai.navn + " " + + Nikolai.fødselsmåned + " " + "" + Nikolai.fødselsdag + " "
                + minklasse.KlasseNavn + " " + minklasse.SemesterStart.ToString("yyyy-MM-dd") + " " + "født i sæsonen" + " " +
                Nikolai.Seasons());
            
            foreach(Studerende x in minklasse.KlasseListe)
            {
                Console.WriteLine("Klasseliste" + " " + x.navn);
            }

            Console.WriteLine(Nikolai.Seasons() + " " + Jannick.Seasons());

            minklasse.CountSeasons();

            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
