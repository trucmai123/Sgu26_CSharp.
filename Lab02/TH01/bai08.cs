using System;

static class bai08
{
    static void HoanVi(ref double a, ref double b)
    {
        double tam = a;
        a = b;
        b = tam;
    }

    public static void xuly()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Truoc khi hoan vi:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        HoanVi(ref a, ref b);

        Console.WriteLine("Sau khi hoan vi:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}