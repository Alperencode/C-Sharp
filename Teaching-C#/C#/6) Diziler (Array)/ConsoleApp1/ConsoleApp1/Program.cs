using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Languages = { "Python", "C++", "Java", "Php", "Swift", "C#" };   // Tanımlanmış dizi
            string[] Animals = new string[3];   // İçi boş dizi tanıtımı fakat dizinin uzunluğunu belirtmek zorundayız
            
            Animals[0] = "Lion"; // Diziye eleman ekleme

            int uzunluk = Animals.Length;
            

            // Dizinin uzunluğuna kadar satırı okuyup dizinin o düngüdeki index'ine okunan değeri atadım
            Console.WriteLine("3 tane hayvan ismi giriniz:");
            for (int i = 0; i < Animals.Length; i++)
            {
                Animals[i] = Console.ReadLine();
            }

            // Dizideki elemanları foreach kullanarak yazdırdım
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal name: {animal}");
            }

            /*
             * Dizilerin Fonksiyonları
             * 
             * ikinci argümanda verilen değere uyan demek = C harfini içeren elemanlar anlamına geliyor
             * 
             * Languages.Lenght ----- Dizinin uzunluğunu return eder
             * Array.IndexOf(Languages, "Java") ----- Dizideki değerin index numarasını return eder
             * Array.Exists(Languages, language => language.Contains("C")) ----- İkinci argümanda verilen değere uyan bir eleman olup olmadığını kontrol eder, boolean değeri döndürür
             * Array.Find(Languages, language => language.Contains("C")) ----- İkinci argümanda verilen değere uyan ilk elemanı return eder
             * Array.FindLast(Languages, language => language.Contains("C")) ----- İkinci argümanda verilen değere uyan son elemanı return eder
             * Array.FindIndex(Languages, language => language.Contains("C")); ----- İkinci argümanda verilen değere uyan elemanın index numarasını return eder
             * Array.FindAll(Languages, language => language.Contains("C")) ----- İkinci argümanda verilen değere uyan bütün elemanları dizi olarak return eder
             * Array.Reverse(Languages) ----- Diziyi tersine göre yeniden sıralar
            */

            // Languages dizisinde C harfi içeren eleman var mı kontrolü yaptım ve bool değerini ekrana yazdırdım
            var check = Array.Exists(Languages, language => language.Contains("C"));
            Console.WriteLine(check);

            // Languages dizisindeki C harfini içeren ilk elemanın index numarasını yazdırdım
            var index = Array.FindIndex(Languages, language => language.Contains("C"));
            Console.WriteLine(index);
            

        }
    }
}
