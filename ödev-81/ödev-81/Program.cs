static void Main()
        {
            Console.WriteLine("kaç sayi giriceksin: ");
            int adet = int.Parse(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            }

            int ortalama = toplam / adet;

            Console.WriteLine("bu kadar sayi girdin " + adet);
            Console.WriteLine("bu sayıların ortalaması" + ortalama);
        }
    