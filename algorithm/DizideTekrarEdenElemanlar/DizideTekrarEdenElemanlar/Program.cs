using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dizinin boyutunu girin:");
        int boyut = int.Parse(Console.ReadLine());

        string[] dizi = new string[boyut];

        for (int i = 0; i< boyut; i++) 
        {
            Console.WriteLine("{0}. elemanii girin:",i+1);
            dizi[i] = (Console.ReadLine());
        }

        Dictionary<string, int> tekrarSayisi = new Dictionary<string, int>();

        foreach (string i in dizi)
        {
            if (tekrarSayisi.ContainsKey(i))
            {
                tekrarSayisi[i]++;
            }
            else
            {
                tekrarSayisi[i] = 1;
            }
        }

        Console.WriteLine("Tekrar eden elemanar : ");
        foreach (var kelime in tekrarSayisi)
        {
            if(kelime.Value > 1)
            {
                Console.WriteLine("Eleman: {0}, Tekrar sayısı: {1}", kelime.Key, kelime.Value);
            }
        }

    }
}