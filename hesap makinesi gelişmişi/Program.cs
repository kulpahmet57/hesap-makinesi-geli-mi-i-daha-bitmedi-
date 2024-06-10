using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi_gelişmişi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("işlem için, + için 1, - için 2, / için 3, * için 4 ve ortamalama hesaplama 5 ve bunlar dışında alan hesaplama için 6 yı seçiniz");
            int seçilenişlem = Convert.ToInt32(Console.ReadLine());



            if (seçilenişlem == (Convert.ToInt32 = 1(1, 2, 3, 4, 5))) ;
            {
                Console.WriteLine("Lütfen ilk sayıyı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci sayıyı giriniz");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                
                double toplam = sayi1 + sayi2;
                double çıkarma = sayi1 - sayi2;
                double bölme = sayi1 / sayi2;
                double çarpma = sayi1 * sayi2;
                double ortalama = (sayi1 + sayi2) / 2;

                if (seçilenişlem == 1)
                {
                    Console.WriteLine(toplam);
                }

                else if (seçilenişlem == 2)
                {
                    Console.WriteLine(çıkarma);
                }

                else if (seçilenişlem == 3)
                {
                    Console.WriteLine(bölme);
                }

                else if (seçilenişlem == 4)
                {
                    Console.WriteLine(çarpma);
                }

                else if (seçilenişlem == 5)
                {
                    Console.WriteLine(ortalama);
                }

                else
                {
                    Console.WriteLine("geçersiz işlem");
                }
            }






            Console.WriteLine("Sonuçlar");






            Console.ReadKey();
        }
    }
}
