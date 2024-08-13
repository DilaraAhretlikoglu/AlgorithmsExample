// Fibonacci Serisi: Kullanıcıdan bir sayı alarak bu sayıya kadar Fibonacci serisini ekrana yazdıran bir program yazın. (Örneğin, 7 için: 0, 1, 1, 2, 3, 5, 8)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive number :");
        int n = int.Parse(Console.ReadLine());
        FibonacciSeries(n);

    }

    static void FibonacciSeries(int number)
    {
        if(number < 0)
        {
            Console.WriteLine("Please, enter a positive number !");
            return;
        }
        int first = 0;
        int second = 1;

        List<int> series = new List<int>();

        series.Add(first);
        series.Add(second);

        while(true)
        {
            int third = first + second;

            if(third > number)
            {
                break;
            }
            series.Add(third);

            first = second;
            second = third;
        }

        Console.WriteLine("Fibonacci Series:");
        foreach (int sayi in series)
        {
            Console.Write(sayi + " "); 
        }
        Console.WriteLine(); 


    }
}