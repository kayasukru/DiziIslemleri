using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        //Array | Dizi | Tanımlama

        // 1
        int[] sayilar = new int[] { 5, 3, 8, 10, 2, 1 };

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
        Console.WriteLine();

        // 2
        var numbers = Array.CreateInstance(typeof(int), 5); // Dizinin veritipi ve eleman sayısı berlilenir
        numbers.SetValue(19, 4);
        numbers.SetValue(12, 1);
        numbers.SetValue(14, 3);
        numbers.SetValue(16, 2);
        numbers.SetValue(17, 0);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers.GetValue(i));
        }
        Console.WriteLine();

        // 3
        var arr = new ArrayList();
        arr.Add(26);
        arr.Add(22);
        arr.Add(21);
        arr.Add(28);
        arr.Add(20);
        arr.Add(23);
        foreach (var a in arr)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        // Sıralanıyor
        Array.Sort(sayilar);

        Array.Sort(numbers);

        arr.Sort();

        Console.WriteLine("Sıralandı:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers.GetValue(i));
        }
        Console.WriteLine();

        foreach (var a in arr)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        Console.WriteLine("Eleman silme");
        // Eleman dedğeri silme
        Array.Clear(sayilar, 2, 2); //sayilar dizisinde 2. indisten başlayarak 2 elemanın değerini siler
        foreach (var s in sayilar)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();

        Console.WriteLine("sayilar dizisinde 10 değerini taşıyan elamanın indisi : " + Array.IndexOf(sayilar, 10) ); // sayilar dizisinde 10 değerini arar, indisini döndürür
        Console.WriteLine("sayilar dizisinde 22 değerini taşıyan elaman olmadığı için -1 değerini verir : " + Array.IndexOf(sayilar, 22) ); // sayilar dizisinde 22 değerini arar, indisini döndürür. Bulamazsa -1 değerini döndürür

    }
}