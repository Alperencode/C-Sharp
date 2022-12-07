using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Liste kullanımı 
            List<string> Meyveler1 = new List<string>();

            // Elemanları tanımlı liste oluşturma
            List<string> Meyveler = new List<string>() { "Elma", "Armut", "Ananas" };
            // Console.WriteLine(Meyveler);

            // index
            // Meyveler = ["Elma", "Armut", "Limon", "Ananas", "Havuç"] 
            //                0       1        2        3         4

            // Listeye eleman ekleme
            Meyveler.Add("Karpuz");
            Meyveler.Add("Kavun");

            // Listeden eleman silme (değeri ile - Remove)
            Meyveler.Remove("Elma");

            // Listeden eleman silme (index ile - RemoveAt)
            Meyveler.RemoveAt(0);

            //Console.WriteLine(Meyveler[0]);

            // Listenin uzunluğunu bulmak
            int uzunluk1 = Meyveler.Count;
            //Console.WriteLine(uzunluk1);

            // Sude Çalışma

            // Liste oluşturma
            // Filmler adında bir liste tanıtıp, tanımlarken içine 4 tane film atayın
            // sonraki satırda listeye eleman ekleme metoduyla başka bir film ekleyin
            List<string> Filmler = new List<string>() { "LOTR","The GodFather","The Prestige","Forest Gump" };
            Filmler.Add("Spiderman-No Way Home");


            // Eleman Çıkarma
            // Yukarıda tanıttığınız listenin 0. indexindeki elemanı silin
            // Yukarıda tanıttığınız listeden film ismini kullanarak bir eleman siliniz
            // Filmler.RemoveAt(0);
            // Filmler.Remove("The GodFather");



            // Liste uzunluğu
            // Listenin uzunluğunu ekrana yazdırın
            int uzunluk = Filmler.Count;
            // Console.WriteLine(uzunluk);


            // For döngüsü kullanarak liste elemanlarını ekrana yazdırın
            for(int i=0;i<uzunluk;i++)
            {
                // Console.WriteLine(Filmler[i]);
            }


            // For döngüsü kullanarak ile listeyi temizleyin
            // Not: index numarasına göre silme işlemi yapmak için Filmler.RemoveAt()
            for(int i=0;i<Filmler.Count;i++)
            {
                Filmler.RemoveAt(i);
            }


            // Foreach
            List<string> Names = new List<string>() { "Alperen", "Sude", "Efe", "Ahmet", "Veli" };

            for(int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(Names[i]);
                if(Names[i] == "Efe")
                {
                    break;
                }
            }

            foreach (var name in Names)
            {
                Console.WriteLine(name);
                if (name == "Efe")
                {
                    break;
                }
            }

            List<int> Sayılar = new List<int>() {11,47,97,13,55,46,38,66,21,24,28};

            foreach(var sayı in Sayılar)
            {
                if (sayı % 2 == 0)
                {
                    Console.WriteLine(sayı);
                }           
            }



            /* Listelerin Fonksiyonları 
            * 
            * Names.Remove("Alperen");  ----- Elemanın değerini kullanarak silme
            * Names.RemoveAt(0); ----- Elemanın index'ini kullanarak sile
            * Names.Insert(0,"Mike"); ----- Spesifik index'e değer atama
            * Names.Count ----- Listenin uzunluğunu return eder
            * Names.IndexOf("Alperen"); ----- Verilen değerin index numarasını return eder
            * Names.LastIndexOf("Alperen") ----- Aynı değere sahip birden fazla eleman var ise bu fonksiyon o değere sahip son index numarasını return eder
            * Names.Contains("Alperen") ----- Boolean return eder. Eğer liste "Alperen" içeriyorsa -> true, içermiyorsa -> false
            * Names.Sort() ----- Alfabetik olarak listeyi yeniden sıralar
            * Names.Reverse() ----- Listeyi tersine göre yeniden sıralar
            * Names.Clear() ----- Listeyi temizler (içindeki değerleri siler)
            * String[] NameArray = Names.ToArray() ----- listeyi Array'e (diziye) dönüştürür
            * 
            */

        }
    }
}
