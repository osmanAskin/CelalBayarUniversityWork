static void Main()
        {
            int asalTaban = 2;
            Console.WriteLine("asal sayi programi");
            Console.WriteLine("sayi gir");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string sonuc = (sayi == 1) ? "asal değil" : $"{sayi} asal sayidir";

            for (int i = 2; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    sonuc = $"{sayi} sayısı asal değil";
                    break;
                }
            }

            Console.WriteLine(sonuc);
            Console.ReadKey(true);
        }