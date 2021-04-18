using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam,puan=0,dogruCevapSayisi=0, yanlisCevapSayisi=0;
            char devamMi;

            do
            {
                Random rastgele = new Random();
                int sayi1 = rastgele.Next(1, 101); //101 dahil değil en son 100 verir.
                int sayi2 = rastgele.Next(1, 101);
                toplam = sayi1 + sayi2;
                Console.WriteLine("Tutulan sayı 1: " + sayi1 + "\nTutulan sayı 2: " + sayi2);
                Console.WriteLine("Bu sayıların toplamı nedir?");
                int kullanıcıToplam = int.Parse(Console.ReadLine()); //kullanıcının girdiği değeri okuyoruz
                
                if (kullanıcıToplam == toplam)
                {
                    dogruCevapSayisi++;
                    puan += 5;
                    Console.WriteLine("Tebrikler bildiniz.");
                }
                else
                {
                    yanlisCevapSayisi++;
                    puan -= 2;
                    Console.WriteLine("Üzgünüm bilemediniz.");
                }
                Console.WriteLine("Tekrar oynamak istiyor musunuz?");
                devamMi = char.Parse(Console.ReadLine());
            } while (devamMi == 'e' || devamMi == 'E');

            Console.WriteLine("Doğru cevap sayısı  :  {0}",dogruCevapSayisi);
            Console.WriteLine("Yanlış cevap sayısı : {0}",yanlisCevapSayisi);
            Console.WriteLine("Toplam puanınız     :  {0}",puan);
            Console.ReadLine();
        }
    }
}
