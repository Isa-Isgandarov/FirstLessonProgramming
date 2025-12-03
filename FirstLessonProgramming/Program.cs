using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Birinci ededi daxil edin");
        int var1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ikinci ededi daxil edin");
        int var2 = int.Parse(Console.ReadLine());

        int sum = Sum(var1, var2);

        Console.WriteLine("Cem budur: " + sum);
    }

    // iki verilən ədədi toplayan metod
    public static int Sum(int var1, int var2)
    {
        return var1 + var2;
    }
}
