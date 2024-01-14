//kullanıcıdan sayi al
//aldığın sayi ile 1 arasında kaç sayı var bul
//buldugun sayılardan t olanları mi ç olanları mı toplayacaksın secim
//ç ise 2den başlat 2 arttır t ise 1 den başlat 2 arttır
//
using System;

Console.WriteLine("Sayi giriniz");
int sayi1 = int.Parse(Console.ReadLine());

var arasayi = sayi1 - 1;
Console.WriteLine($"Girdiğiniz Sayı İle 1 Arasında :{arasayi} tane sayi vardir");

Console.WriteLine("Tek ise 'T'");
Console.WriteLine("Çift ise 'Ç'");

char secim = char.Parse(Console.ReadLine().ToUpper());
int toplam = 0;
bool calisiyor = true;

while (calisiyor)
{


    if (secim == 'T')
    {
        for (int sayi = 1; sayi <= sayi1; sayi += 2)
        {
            toplam += sayi;
        }
        Console.WriteLine($"İki sayı arasındaki tek sayıların toplamı: {toplam}");
    }

    if (secim == 'Ç')
    {
        for (int sayi = 2; sayi <= sayi1; sayi += 2)
        {
            toplam += sayi;
        }
        Console.WriteLine($"İki sayı arasındaki çift sayıların toplamı: {toplam}");
    }
    else
    {
        Console.WriteLine("Geçersiz bir giriş yaptınız");
    }
    Console.WriteLine("Programı tekrar başlatmak için 'J' tuşuna basınız. Çıkış yapmak için başka bir tuşa basınız.");
    char devam = char.Parse(Console.ReadLine().ToUpper());
    calisiyor = (devam == 'J');
    Console.Clear();

}
Console.ReadLine();