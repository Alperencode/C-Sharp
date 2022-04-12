 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Toplama Fonksiyonu
            static int toplamaFonksiyonu(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine("10 + 20 = " + toplamaFonksiyonu(10, 20));
    
            // Hello world Fonksiyonu
            static string helloWorld()
            {
                return "Hello World";
            }

            Console.WriteLine(helloWorld());            
           
            static void helloWorld2()
            {
                Console.WriteLine("Hello World");
            }

            helloWorld2();

            // Sude Çalışma

            // Çift sayı kontrol fonksiyonu 
            /*
             * Parametre olarak bir sayi alan ve sayı çift ise true değil ise false
             * değeri döndüren fonksiyonu yazınız
             */

            static bool ciftsayi(int x)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Karşılama Fonksiyonu
            /*
             * Parametre olarak bir string alan ve ekrana "Hoşgeldiniz, *string*!" 
             * yazdıran fonksiyonu yazınız
             */

            static void hosgeldiniz(string a)
            {
               Console.WriteLine("Hoşgeldiniz, " + a + "!");
            }

            

            // Çarpma Fonksiyonu
            /*
             * Parametre olarak iki int değeri alan ve değerlerin çarpımını döndüren 
             * fonksiyonu yazınız
             */
            static int alperen(int x,int y)
            {
                return x *y;
            }
            

            Console.WriteLine("Bir sayi giriniz: ");
            string input = Console.ReadLine();
            int sayi;
            Int32.TryParse(input, out sayi);

            // Çift sayı kontrol fonksiyonunun if else ile kullanımı
            // Yapımının yol var:
            // 1) Dönen değer zaten boolean olduğu için if içinde kontrol etmek
            // 2) yeni bir bool değişkeni tanımlayıp yeni değişkeni kontrol etmek

            if (ciftsayi(sayi))
            {
                Console.WriteLine("sayi cifttir");
            }
            else
            {
                Console.WriteLine("sayi tektir");
            }



            // Karşılama Fonksiyonu kullanımı
            Console.WriteLine("İsminizi giriniz");
            string aa = Console.ReadLine();

            hosgeldiniz(aa);

            // Çarpma Fonksiyonu kullanımı

            alperen(10,20);
        }
    }
}
