using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 30  ;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //class çağırma aşağıdaki code
            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler) 
            {
                Console.WriteLine(Urun.Adi);

                Console.WriteLine(Urun.Fiyati);

                Console.WriteLine(Urun.Aciklama);
              
                Console.WriteLine("---------------");

            }

            Console.WriteLine("------Metodlar------);

            SepetManager sepetManager = new SepetManager();

            //metod Çağırma aşağıdaki code farklı 5 yada daha fazla sayfada çalışıyormuş gibi düşünebiliriz.
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);
           









        }
    }
}




//dont repeat yourself - DRY - Clean Code - Best Practice 