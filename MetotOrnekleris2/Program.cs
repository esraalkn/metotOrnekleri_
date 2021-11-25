using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnekleris2
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru 2
            //Kendisine gönderilen int tipinde 2 sayıdan büyük olanı döndüren metodu yazınız.
            //BuyukDondur()

            //Soru 3
            //Kendisine gönderilen 3 sayıdan büyük olanı döndüren metodu yazınız.
            //BuyukDondur() 3 parametre
            //püf: if kullanmayın. aynı metodu 2 parametreli kullanarak çözmeye çalışın.
            BuyukDondur(50, 55, 80);
            
            Console.ReadLine();
        }
        static int BuyukDondur(int sayi1,int sayi2)
        {
            
            
            if (sayi1>sayi2)
            {
                Console.WriteLine($"{sayi1} büyüktür {sayi2}' den");
                return sayi1;
            }
            else
            {
                Console.WriteLine($"{sayi2} büyüktür {sayi1}' den");
                return sayi2;
            }

            
        }

        static int BuyukDondur(int sayi1,int sayi2,int sayi3)
        {
            int buyuk = BuyukDondur(sayi1, sayi2);
            int enBuyuk = BuyukDondur(buyuk, sayi3);
            return enBuyuk;
        }
    }
}
