using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        //Her bliver der lavet proberties, egenskaber
       public string navn;
       public int fødselsmåned;
       public int fødselsdag;
       

        public Studerende(string Navn, int Fødselsmåned, int Fødselsdag) //Dette er en construcor
        {
            //Her forbinder vi parameterne til proberties
            this.navn = Navn;
            this.fødselsdag = Fødselsdag;
            if (Fødselsmåned > 0 && Fødselsmåned < 13)
                this.fødselsmåned = Fødselsmåned;
            else
                this.fødselsmåned = 1;

        }
         
       public string Seasons()
        {
            int month = this.fødselsmåned;
            string x = "Kan ikke vises";

            if (month == 1 || month == 2 || month == 12)
            {
                x = "vinter";
            }
            if (month >= 3 && month <= 5)
            {
                x = "Forår";
            }
            if (month >= 6 && month <= 8)
            {
                x = "Sommer";
            }
            if (month >= 9 && month <= 11)
            {
                x = "Efterår";
            }
            return (this.navn + " er født i " + x);

        }

       
    }


}
