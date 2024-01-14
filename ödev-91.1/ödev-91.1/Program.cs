class Program
{
    static void Main()
    {
        Console.WriteLine("sayı gir:");
        if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0 && sayi < 100)
        {
            Console.WriteLine("uygun sayı girdiniz.");
        }
        else
        {
            Console.WriteLine("uygun sayı girmediniz.");
            Console.WriteLine("lütfen 1 ile 99 arasında bir sayı girin.");
        }
    }
}
