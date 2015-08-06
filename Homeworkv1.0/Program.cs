using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkv1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev:
            //Klavyeden girilen değer ile önce:
            //1.Kare, 2.Dikdörtgenden birinin seçimi yapılacak (Lutfen bir seçim yapınız:)
            //ve ona göre de seçilen seçim için bir if e daha girecek ve seçtiğiniz şeklin alan ve çevresini soracak
            //1.Alan
            //2.Çevre
            //lütfen birini seçiniz:
            //duruma göre hesaplamasını yapıp erkana sonucu yazan kodu yazın


            int Alan, Cevre;
            Console.WriteLine("Hesaplamak için seçim yapınız:\n1.Kare\n2.Dikdörtgen");
            int secim = int.Parse(Console.ReadLine());

            #region step1
            if (secim == 1)
            {
                Console.Write("Karenin bir kenarını giriniz: ");
                int kareKenar = int.Parse(Console.ReadLine());

                Console.WriteLine("Hesaplamak için Seçim Yapınız: \n1.Alan\n2.Çevre");
                int kareHesap = int.Parse(Console.ReadLine());

                if (kareHesap == 1)
                {
                    Alan = kareKenar * kareKenar;
                    Console.Write("Sonuç: " + Alan);
                }
                else if (kareHesap == 2)
                {
                    Cevre = 4 * kareKenar;
                    Console.Write("Sonuç: " + Cevre);
                }
                else
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız.");
                }
            }
            #endregion

            #region step2
            if (secim == 2)
            {
                Console.Write("Dikdörtgenin kısa kenarını giriniz: ");
                int kısaKenar = int.Parse(Console.ReadLine());
                Console.Write("Dikdörtgenin uzun kenarını giriniz: ");
                int uzunKenar = int.Parse(Console.ReadLine());
                Console.WriteLine("Hesaplamak için seçim yapın:\n1.Alan\n2.Cevre");
                int dikdörtgenHesap = int.Parse(Console.ReadLine());

                if (dikdörtgenHesap == 1)
                {
                    Alan = uzunKenar * kısaKenar;
                    Console.Write("Sonuç: " + Alan);
                }
                else if (dikdörtgenHesap == 2)
                {
                    Cevre = 2 * (uzunKenar + kısaKenar);
                    Console.Write("Sonuç: " + Cevre);
                }
                else
                {
                    Console.Write("Yanlış bir tuşa bastınız.");
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
