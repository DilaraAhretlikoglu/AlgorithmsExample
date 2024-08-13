class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin girin: ");
        string metin = Console.ReadLine();
        Dictionary<char, int> tekrarSayisi = new Dictionary<char, int>();

        foreach (char item in metin)
        {
            if (tekrarSayisi.ContainsKey(item))
            {
                tekrarSayisi[item]++;
            }
            else
            {
                tekrarSayisi[item] = 1;
            }

        }
        Console.WriteLine("Tekrar eden harfler : ");
        foreach (var item in tekrarSayisi)
        {
            if (item.Value >= 1)
            {
                Console.WriteLine("Harf: {0}, Tekrar sayısı: {1}", item.Key, item.Value);
            }
        }
    }
}