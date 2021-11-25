using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnekleri3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kendisine gönderilen fiyata KDV ekleyip geri döndüren metodu yazınız.
             * ürün kategorisine göre Kdv eklenecek
             * gıda: %8, eğitim:%5,diğerleri:%8
             * parametreler: fiyat,kategori
             */
            Console.WriteLine("ürün no gir");
            Console.WriteLine("1-gıda");
            Console.WriteLine("2-eğitim");
            Console.WriteLine("3-diğer");
            string urunAD = Console.ReadLine();
            Console.WriteLine("Ürün fiyat gir");
            double urunFiyat = Convert.ToInt32(Console.ReadLine());
            double sonFiyat = parametreler(urunAD, urunFiyat);
            Console.WriteLine("kdvli fiyat: "+sonFiyat);
            Console.ReadLine();
        }

        static double parametreler(string kategori,double fiyat )
        {

            
            double kdvh = 0;
            if (kategori=="g")
            {
                
              
                
                kdvh = fiyat + (fiyat * 8 / 100);
             

                

            }
            else if (kategori=="e")
            {
                kdvh = fiyat + (fiyat * 5 / 100);
                

               
            }
            else
            {
                kdvh = fiyat + (fiyat * 18 / 100);
                

                
            }
            return kdvh;
        }
    }
}
