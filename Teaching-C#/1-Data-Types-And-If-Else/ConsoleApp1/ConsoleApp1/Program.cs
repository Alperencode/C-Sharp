 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken tipleri

            int x = 10;
            float y = 3.14f;
            string z = "Hello World";
            double q = 3.14159265359;
            bool k = true;
            bool j = false;

            // if-else Örneği

            // Input alımı
            Console.WriteLine("Bir sayi giriniz: ");
            string input = Console.ReadLine();
            Console.WriteLine("İkinci sayiyi giriniz: ");
            string input2 = Console.ReadLine();
            int sayi1;
            int sayi2;
            Int32.TryParse(input, out sayi1);
            Int32.TryParse(input2, out sayi2);

            // sayi1 ve sayi2 değişkenlerinin karşılaştırmasını yapınız
            // sayiların eşit olma durumunu else if olarak belirtiniz
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Sayi 1 daha büyük");
            }else if(sayi1 == sayi2)
            {
                Console.WriteLine("Sayilar esit");
            }
            else
            {
                Console.WriteLine("Sayi2 daha büyük");
            }

        }
    }
}
