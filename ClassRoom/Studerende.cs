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
            
            return "season";
        }

       
    }


}
