 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // if-else çift sayı örneği

            Console.WriteLine("Bir sayi giriniz: ");
            string input = Console.ReadLine();
            int sayi;
            Int32.TryParse(input, out sayi);

            // Girilen sayi değişkeninin çift sayı olup olmadığını kontrol ediniz
            // sayının 0 olup olmadığını kontrol ediniz

            if( sayi==0)
            {
                Console.WriteLine("girdiginiz sayi 0 dır");
            }
            else if(sayi%2==0)
            {
                Console.WriteLine("girdiginiz sayi cift sayidir");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayi tek sayidir");
            }
    
        }
    }
}
