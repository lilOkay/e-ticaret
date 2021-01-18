using System;
using System.Collections.Generic;
using System.Text;

namespace e_ticaret
{
    class Urunmanager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürününüz sepete eklendi! : " + urun.Name + " Fiyatı : " +urun.Price+ " stockdaki adet sayısı : " +urun.Stock);
        }
        public void Buy(Urun urun)
        {
            Console.WriteLine("Ürün satın alındı! : " + urun.Name + " Fiyatı : " + urun.Price + " stockdaki adet sayısı : " + urun.Stock);
        }
        public void Sil(Urun urun)
        {
            Console.WriteLine("ürnünüz sepetten silindi! : " + urun.Name + " Fiyatı : " + urun.Price + " stockdaki adet sayısı : " + urun.Stock);
        }
        
    }
}
