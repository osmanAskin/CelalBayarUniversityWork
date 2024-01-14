int sayi1;
int sayi2;
int toplam;

Console.WriteLine("sayi1 giriniz");
sayi1 = int.Parse(Console.ReadLine());

Tekrar:

Console.WriteLine("sayi2 giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Çıkmak İçin 'Q' bas");

if (sayi2 == 'Q')
    Console.WriteLine("Programdan Çıkılıyor");

else
{
    toplam = sayi1 + sayi2;
    Console.WriteLine($"sayıların toplamı{toplam}");
    goto Tekrar;

}
Console.ReadKey(true);

