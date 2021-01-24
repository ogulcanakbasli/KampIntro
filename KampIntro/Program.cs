using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizorani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalıs butonu");

            }
            else if ((dolarDun < dolarBugun))
            {
                Console.WriteLine("artıs butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
 
            }
            else
            {
                Console.WriteLine("giriş yap butonu")
            }
           


           

          






        }
    }
}
