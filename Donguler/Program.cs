using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java ";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
        


            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı" , 
                "Programlamaya başlangıç için temel kurs" , "Java " ,"phyton"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti")
            foreach (string kurs in kurslar)
            {
                Console.WriteLine();

            }
            
        }
    }
}
