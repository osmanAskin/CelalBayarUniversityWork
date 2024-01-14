using System;

namespace odev3
{
    class tekcift
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ilk sayi gir");
            int sayi;
            int sayi2;

            if (int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.WriteLine("ikinci sayi gir");
                if (int.TryParse(Console.ReadLine(), out sayi2))
                {
                    Console.WriteLine("tekler mi çiftler mi? (T/Ç)");
                    string tercih = Console.ReadLine().ToUpper();

                    int toplam = 0;
                    for (int i = sayi; i <= sayi2; i++)
                    {
                        if ((tercih == "T" && i % 2 != 0) || (tercih == "Ç" && i % 2 == 0))
                        {
                            toplam += i;
                        }
                    }

                    Console.WriteLine("sayılarin toplamı = " + toplam);
                }
                else
                {
                    Console.WriteLine("geçersiz ikinci sayi.");
                }
            }
            else
            {
                Console.WriteLine("geçersiz birinci sayi.");
            }
        }
    }
}
