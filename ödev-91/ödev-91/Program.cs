class Program
{
    static void Main()
    {
        Console.WriteLine("sayi gir");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0 && sayi < 1000)
        {
            Console.WriteLine("uygun sayi");
        }
        else
        {
            Console.WriteLine("hatali sayi");
            Console.WriteLine("0 ile 1000 arasinda olsun");
        }
    }
}
