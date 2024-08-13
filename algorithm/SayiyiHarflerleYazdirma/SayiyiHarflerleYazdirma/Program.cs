//Sayıyı Harflerle Yazma: 1 ile 10 arasında bir sayı alarak bu sayıyı kelime olarak ekrana yazdıran bir program yazın. (Örneğin, 1 için "Bir", 5 için "Beş".)
class Program
{
    static void Main(string[] args)
    {
        string[] kelimeler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz", "On" };
        Console.WriteLine("1-10 aralığında bir sayi girin:");
        int sayi = int.Parse(Console.ReadLine());

        if(sayi > 0 && sayi <= 10) 
        {
            Console.WriteLine("Girdiğiniz sayı kelime olarak: {0}", kelimeler[sayi - 1]);
        }
        else
        {
            Console.WriteLine("Hatali deger girdiniz!");
        }
    }
}
