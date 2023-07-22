using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCompetition3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** Bilgi Yarısmasına Hosgeldiniz *** ");
            Console.WriteLine();
            int soru = 1;
            string cevap;

            if (soru == 1)
            {
                Console.WriteLine("1) Turkiye' nin başkenti neresidir ?");
                Console.WriteLine();
                Console.WriteLine("A) Ankara");
                Console.WriteLine("B) Istanbul");
                Console.WriteLine("C) Edirne");
                Console.WriteLine("D) Konya");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlıs cevap, toplam puanınız sıfır(0)");
                }
            }

            if (soru == 2)
            {
                Console.WriteLine();
                Console.WriteLine("2) Gül yetistiriciligi ile meshur olan ilimiz?");
                Console.WriteLine();
                Console.WriteLine("A) Bursa\r\nB) Balıkesir");
                Console.WriteLine("C) Erzurum");
                Console.WriteLine("D) Isparta");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlıs cevap, toplam puanınız 1");
                }
            }

            if (soru == 3)
            {
                Console.WriteLine();
                Console.WriteLine("3) Mimar Sinan'ın ustalık eseri olan Selimiye camii hangi ilimizdedir ?");
                Console.WriteLine();
                Console.WriteLine("A) Bursa");
                Console.WriteLine("B) Isparta");
                Console.WriteLine("C) Edirne");
                Console.WriteLine("D) Amasya");
                Console.WriteLine();
                Console.WriteLine("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("Tebrikler, yarısmayı kazandınız");
                    Console.WriteLine("Toplam puanınız 3");
                }
                else
                {
                    Console.WriteLine("Yarısmayı kaybettiniz");
                    Console.WriteLine("Toplam puanınız 2");
                }
            }




            Console.Read();
        }
    }
}
