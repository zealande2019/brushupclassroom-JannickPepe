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
            this.fødselsmåned = Fødselsmåned;
            this.fødselsdag = Fødselsdag;
            

        }
         
        public string Seasons()
        {
            int month = this.fødselsmåned;
            string x = "DEFAULT";
            if (month == 12 || month == 1 || month == 2)
            {
               x = "vinter";
            }
            if (month == 3 || month == 4 || month == 5)
            {
                x = "forår";
            }
            if (month == 6 || month == 7 || month == 8)
            {
                x = "sommer";
            }
            if (month == 9 || month == 10 || month == 11)
            {
                x = "eftår";
            }
            return x;
        }

       
    }


}
