using System;

namespace e_ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Name = "etek";
            urun1.Price = 30.5;
            urun1.Stock = 7;

            Urun urun2 = new Urun();
            urun2.Name = "ayakkabı";
            urun2.Price = 99.90;
            urun2.Stock = 15;

            Urun urun3 = new Urun();
            urun3.Name = "çanta";
            urun3.Price = 88.7;
            urun3.Stock = 0;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach(var urun in urunler)
            {
                Console.WriteLine("-------Ürünlerimiz-------");
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Stock);
            }

            Urunmanager urunmanager = new Urunmanager();
            {
            urunmanager.Ekle(urun1);
            Console.WriteLine("------------------------------------");
            urunmanager.Buy(urun2);
                Console.WriteLine("------------------------------------");
                urunmanager.Sil(urun3);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
