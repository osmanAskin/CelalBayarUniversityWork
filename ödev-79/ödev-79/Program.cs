class Program
{
    static void Main()
    {
        Console.Write("dönüştürülecek sayi: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int ikiliDeger = sayi;
        int onluDeger = 0, tabanDeger = 1, basamakDeger;

        while (sayi > 0)
        {
            basamakDeger = sayi % 10;
            onluDeger += basamakDeger * tabanDeger;
            sayi /= 10;
            tabanDeger *= 2;
        }

        Console.WriteLine($"İkili (Binary) Sayı: {ikiliDeger}");
        Console.WriteLine($"Onlu (Decimal) Sayı: {onluDeger}");
    }
}
