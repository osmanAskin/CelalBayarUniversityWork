class Program
{
    static void Main()
    {
        double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

        foreach (double burs in burslar)
        {
            double yeniBurs = (burs >= 500) ? burs : (burs * 1.1) + 50;

            Console.WriteLine(yeniBurs);
        }

        Console.ReadKey(true);
    }
}
