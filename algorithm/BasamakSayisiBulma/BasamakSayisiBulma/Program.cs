using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayi girin");
        int sayi = int.Parse(Console.ReadLine());

        int basamak = BasamakSayisiHesapla(sayi);
        Console.WriteLine("{0} sayisi {1} basamaklidir", sayi, basamak);
    }
    static int BasamakSayisiHesapla(int sayi)
    {
        int counter = 0;
        while(sayi != 0)
        {
            sayi = sayi / 10;
            counter++;
        }
        return counter;
    }
}
