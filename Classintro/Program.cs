using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "ogulcan akbasli";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "ayse akbasli";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "phtyhon";
            kurs3.Egitmen = "Adem akbasli";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Beril akbasli";
            kurs4.IzlenmeOranı = 100;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen + ":") ;
            //Aşağıdaki örnek array örneği kurs ile başlayıp kurs4 ile biten
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 , kurs4  };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + ":" +kurs.IzlenmeOranı);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }


    }


}
