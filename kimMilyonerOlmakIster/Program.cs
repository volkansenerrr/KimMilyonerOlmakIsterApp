using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.GetEncoding("ibm857");
         
            Oyun oyun = new Oyun();

            oyun.soruEkle("Hangi gezegen güneş sistemindeki beşinci gezegendir?", new string[] { "Mars", "Jüpiter", "Neptün", "Pluton" }, "B" , 1000 );
            oyun.soruEkle("Bir yıl kaç aydan oluşur ?", new string[] { "10", "12", "20", "9" }, "B", 1000);
            oyun.soruEkle("Hidrojen ve oksijenin birleşmesi sonucu hangi bileşik oluşur ?", new string[] { "Su", "Vodka", "Viski", "Bira" }, "A", 1000);
            oyun.soruEkle("İnsan vücudunda hangi organ kanı temizler?", new string[] { "Dalak", "Kalp", "Böbrek", "Kuyruk Sokumu" }, "C", 1000);
            oyun.soruEkle("İnsan vücudunda hangi organ oksijenli kanı vücuda dağıtır?", new string[] { "Dalak", "Meme", "Göbek", "Kalp" }, "D", 1000);
            oyun.soruEkle("Dünyanın en büyük gölü hangisidir?", new string[] { "Volkan Gölü", "Hazır Gölü", "Billur Gölü", "Van Gölü" }, "B", 1000);
            oyun.soruEkle("Bir otobüs 2 saatte 120 km yol alıyor. Bu otobüsün hızı kaç km/saat’tir?", new string[] { "60 km/saat", "70 km/saat", "600 km/saat", "6054654516 km/saat" }, "A", 1000);
            oyun.soruEkle("Osmanlı İmparatorluğu hangi yıl kurulmuştur?", new string[] { "1923", "2024", "1299 ", "20222541" }, "C", 1000);
            oyun.soruEkle("Atom numarası 1 olan element hangisidir?", new string[] { "Bali", "Hidrojen", "Su", "Tahta" }, "B", 1000);
            oyun.soruEkle("DNA’nın tam adı nedir?", new string[] { "Deokrisibonukleikfesat asit", "Deoksiribo Nükleik Asit", "Doksanderiparça Asit", "Dostakorku Asit" }, "B", 1000);

            oyun.soruGoster();


        }
    }
}
