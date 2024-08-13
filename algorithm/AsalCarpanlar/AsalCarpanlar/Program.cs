class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        List<int> asalCarpanlar = AsalCarpanlar(sayi);

        Console.WriteLine("Asal çarpanlar:");
        foreach (int asalCarpan in asalCarpanlar)
        {
            Console.WriteLine(asalCarpan);
        }
    }

    static List<int> AsalCarpanlar(int sayi)
    {
        List<int> carpanlar = new List<int>();

        while (sayi % 2 == 0)
        {
            if (!carpanlar.Contains(2))
            {
                carpanlar.Add(2);
            }
            sayi /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(sayi); i += 2)
        {
            while (sayi % i == 0)
            {
                if (!carpanlar.Contains(i))
                {
                    carpanlar.Add(i);
                }
                sayi /= i;
            }
        }

        if (sayi > 1)
        {
            carpanlar.Add(sayi);
        }

        return carpanlar;
    }
}