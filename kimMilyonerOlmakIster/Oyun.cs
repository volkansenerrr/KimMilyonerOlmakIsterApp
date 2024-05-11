using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimMilyonerOlmakIster
{
    internal class Oyun
    {
        public ArrayList sorular = new ArrayList();
        public double toplam;
        public double kesinPara;
        public Oyun() 
        { 
            sorular = new ArrayList();
            toplam = 0;
            kesinPara = 0;
        }
        public void soruEkle(string metin, string[] secenekler, string dogruSecim, double soruDegeri) 
        { 
            Soru s = new Soru(metin,secenekler,dogruSecim, soruDegeri);
            sorular.Add(s);
        }

        
        public void soruGoster() 
        {
            for (int i = 0; i < sorular.Count; i++)
            {
                Console.WriteLine("Toplam para = " + toplam + " TL");
                Soru soru = (Soru)sorular[i];
                Console.WriteLine((i + 1) + ". Soru : " + soru.SoruMetini);

                for (int j = 0; j < soru.Secenekler.Length; j++)
                {
                    string secenek = "";
                    switch (j) 
                    {
                        case 0:
                        secenek = "A";
                        break;  
                        case 1:
                        secenek = "B";
                        break;
                        case 2:
                        secenek = "C";
                        break;
                        case 3:
                        secenek = "D";
                        break;
                    }
                    Console.Write(secenek + ") " + soru.Secenekler[j] + " ");
                }

                Console.WriteLine();

                string gelenCevap = Console.ReadLine();

                if (gelenCevap == soru.DogruSecenek)
                {
                    Console.WriteLine("Tebrikler.");
                    toplam += soru.SoruDegeri;
                    kesinPara = toplam;
                }
                else
                {
                    Console.WriteLine("Kaybettiniz.");
                    Console.WriteLine("Kazandığın para = " + kesinPara);
                    break;
                }

                Console.WriteLine("Çekinizi almak ister misiniz ?");
                Console.WriteLine("Evet : Parayı al");
                Console.WriteLine("Hayır : Devam");
                string devamMi = Console.ReadLine();

                if (devamMi == "Hayır")
                {
                    kesinPara = toplam;
                }
                else if (devamMi == "Evet")
                {
                    Console.WriteLine("Kazanılan para : " + kesinPara + " TL");
                    Console.WriteLine("Hayatta başarılar...");
                    break;
                }
            }
        }
    }
}
