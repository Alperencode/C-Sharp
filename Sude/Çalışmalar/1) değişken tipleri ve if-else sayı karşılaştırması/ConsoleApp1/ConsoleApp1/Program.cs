 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken tipleri

            * x = 10;
            * x = 3.14f;
            * x = "Hello World";
            * x = 3.14159265359;
            * x = true;
            * x = false;

            // Unity'de private ve public değişken farkı

            // if-else örneği

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
            

        }
    }
}
