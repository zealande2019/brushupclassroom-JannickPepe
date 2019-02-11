using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn;
        public List<Studerende> KlasseListe;
        public DateTime SemesterStart;
     

        public KlasseRum()
        {
            this.KlasseListe = new List<Studerende>();
        }


    }
}
