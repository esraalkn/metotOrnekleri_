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
           float s = parametreler("e", 100);
            Console.WriteLine("KDV eklenmiş fiyat : " + s);
            Console.ReadLine();
        }

        static float parametreler(string kategori,int fiyat )
        {

            
            float kdvh = 0;
            if (kategori=="g")
            {
                
              
                
                kdvh = fiyat + (fiyat * 8 / 100);
                Console.WriteLine("");

                return kdvh;

            }
            else if (kategori=="e")
            {
                kdvh = fiyat + (fiyat * 5 / 100);
                Console.WriteLine("");

                return kdvh;
            }
            else
            {
                kdvh = fiyat + (fiyat * 18 / 100);
                Console.WriteLine("");

                return kdvh;
            }
        }
    }
}
