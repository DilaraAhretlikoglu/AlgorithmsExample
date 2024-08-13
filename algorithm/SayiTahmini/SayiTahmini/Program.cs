// Sayı Tahmin Oyunu: 1 ile 100 arasında rastgele bir sayı seçen ve kullanıcıdan bu sayıyı tahmin etmesini isteyen bir program yazın. Kullanıcı tahmin yaparken program daha büyük ya da daha küçük olması gerektiğini söyleyebilir.

class Program
{
    static void Main(string[] args)
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 101);

        int kullaniciTahmini = 0;

        int tahminSayisi = 0;

        while(kullaniciTahmini != sayi)
        {
            tahminSayisi++;
            Console.WriteLine("Tahmin edin :");
            kullaniciTahmini =int.Parse(Console.ReadLine());

            if (kullaniciTahmini < sayi)
                Console.WriteLine("Daha büyük bir sayı tahmin edin");
            else if (kullaniciTahmini > sayi)
                Console.WriteLine("Daha küçük bir sayı tahmin edin");
            else
                Console.WriteLine("Tebrikler! {0} tahminde doğru sayıyı buldunuz.", tahminSayisi);

        }

    }
}
