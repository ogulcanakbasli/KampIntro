using System;
namespace odevlericindenemtahtasi
{
    class MainClass
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.Fiyat = "100dolar";
            urun1.AlinmaOrani = "95";


            product urun2 = new product();
            urun2.Fiyat = "100dolar";
            urun2.AlinmaOrani = "95";


            product urun3 = new product();
            urun3.Fiyat = "100dolar";
            urun3.AlinmaOrani = "95";


            product urun4 = new product();
            urun4.Fiyat = "100dolar";
            urun4.AlinmaOrani = "95";


            product urun5 = new product();
            urun5.Fiyat = "100dolar";
            urun5.AlinmaOrani = "95";


            product[] Migros = new product[] { urun1, urun2, urun3, urun4, urun5 };

            foreach (var urun in Migros)
            {
                Console.WriteLine(urun.Fiyat + ":" + urun.AlinmaOrani + ":");


            }









        }
    }

    class product
    {
        public string Fiyat { get; set; }
        public string AlinmaOrani { get; set; }





    }
}