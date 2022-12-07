 
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static string isim;
        static void Main(string[] args)
        {

            // For 
            // 0'dan başlayıp kullanıcının girdiği sayıya kadar olan sayıları ekrana yazdırın
            Console.WriteLine("Birinci soru için sayı giriniz: ");
            string input1 = Console.ReadLine();
            int sayi1;
            Int32.TryParse(input1, out sayi1);

            for (int i = 0; i <= sayi1; i++)
            {
                Console.WriteLine(i);
            }


            // 0'dan başlayıp 4'er 4'er artarak bulduğu çift sayıları ekrana yazdırın
            Console.WriteLine("İkinci soru için sayı giriniz: ");
            string input2 = Console.ReadLine();
            int sayi2;
            Int32.TryParse(input2, out sayi2);

            for (int i = 0; i <=sayi2; i+=4)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }



            // While 
            // Kullanıcının girdiği isim "Sude" olana kadar ismi istemeye devam eden while döngüsünü yazın
            Console.WriteLine("Üçüncü soru için isim giriniz: ");
            isim = Console.ReadLine();

            while (isim!="Sude")
            {
                Console.WriteLine("Üçüncü soru için isim giriniz: ");
                isim = Console.ReadLine();

                if (isim == "Sude")
                {
                    break;
                }
                
            }



            // do While
            // Aynı örneği do-while ile yapın
            do
            {
                Console.WriteLine("Dördüncü soru için isim giriniz: ");
                isim = Console.ReadLine();

            } while (isim!="Sude");


        }
    }
}
