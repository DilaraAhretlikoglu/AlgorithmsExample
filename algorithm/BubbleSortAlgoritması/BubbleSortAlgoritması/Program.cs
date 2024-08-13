// Bubble Sort Uygulaması: Kullanıcıdan alınan bir dizi üzerinde bubble sort algoritmasını kullanarak diziyi sıralayan bir program yazın. Sonuç olarak sıralı diziyi ekrana yazdırın.
class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 111, 12, 123, 34, 231, 127, 46, 9, 75, 3, 2345, 789, 6 };
        int boyut = dizi.Length;

        for (int i=0; i<boyut-1; i++)
        {
            for (int j = 0; j < boyut-i-1; j++)
            {
                if (dizi[j] > dizi[j+1])
                {
                    int temp = dizi[j];
                    dizi[j] = dizi[j+1];
                    dizi[j+1] = temp;

                }
            }
        }
        Console.WriteLine("Siralanmis Dizi:");
        foreach (int sayi in dizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
}