using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimMilyonerOlmakIster
{
    internal class Soru //Soru sınıfı
    {
        public string SoruMetini { get; set; }
        public string[] Secenekler  { get; set; }
        public string DogruSecenek { get; set; }
        public double SoruDegeri { get; set; }

        public Soru(string soruMetini, string[] secenekler, string dogruSecenek, double soruDegeri ) //Yapıcı metot
        {
            SoruMetini = soruMetini;
            Secenekler = secenekler;
            DogruSecenek = dogruSecenek;
            SoruDegeri = soruDegeri;
        }
    }
}
