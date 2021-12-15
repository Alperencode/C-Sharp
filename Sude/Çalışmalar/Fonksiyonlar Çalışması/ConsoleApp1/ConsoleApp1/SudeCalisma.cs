using System;
namespace örnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            string zorlukderecesi, değer;
            int mana = 0;
            int can = 0;

            string isimAl()
            {
                string ad;
                Console.WriteLine("\nİsminizi giriniz:");
                ad = Console.ReadLine();
                return ad;
            }



            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine("Zorluk derecenizi seciniz:\nKolay\nOrta\nZor\n");
                zorlukderecesi = Console.ReadLine();

                if (zorlukderecesi == "kolay")
                {
                    string isim = isimAl();
                    Console.WriteLine(isim + " oyuna 100 can / 50 mana ile başlayacaksın.\n");
                    can = 100;
                    mana = 50;
                    break;
                }
                else if (zorlukderecesi == "orta")
                {
                    string isim = isimAl();
                    Console.WriteLine(isim + " oyuna 75 can / 40 mana ile başlayacaksın.\n");
                    can = 75;
                    mana = 40;
                    break;
                }
                else if (zorlukderecesi == "zor")
                {
                    string isim = isimAl();
                    Console.WriteLine(isim + " oyuna 50 can / 30 mana ile başlayacaksın.\n");
                    can = 50;
                    mana = 30;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış zorluk derecesi girdiniz.\n");
                }
            }

            void oyunBitti()
            {
                Console.WriteLine("Oyun bitti!");
            }



            void buyukullan(string buyuturu)
            {
                Console.WriteLine("Büyü türünüz: " + buyuturu + "\n");
                mana -= 15;
                can -= 10;
            }

            Console.WriteLine("Büyü türünü giriniz");
            string buyuturu = Console.ReadLine();

            buyukullan(buyuturu);


            dongu = true;
            while (dongu)
            {

                if (can <= 0 || mana <= 0)
                {
                    oyunBitti();
                    break;
                }
                else if (can != 0 && mana != 0)
                {
                    Console.WriteLine("Yapmak istediğiniz işlem seçiniz:\n-can yenile\n-savaşa devam et\n Can : " + can + " Mana: " + mana);
                    değer = Console.ReadLine();

                    if (değer == "can yenile")
                    {
                        void canyenilee()
                        {
                            Console.WriteLine("10 can puanı aldınız. Can: " + can + "\n");
                            can += 10;
                        }
                        canyenilee();
                    }
                    else
                    {
                        Console.WriteLine("\nBüyü türünü giriniz");
                        string buyuturu2 = Console.ReadLine();
                        buyukullan(buyuturu2);

                    }
                }

            }
        }
    }
}