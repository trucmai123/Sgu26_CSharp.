using System;

static class bai06
{
    static int NhapSoNguyen(string tenBien)
    {
        Console.Write("Nhap " + tenBien + ": ");
        return int.Parse(Console.ReadLine()!);
    }

    static int TimMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }

    public static void xuly()
    {
        int a = NhapSoNguyen("a");
        int b = NhapSoNguyen("b");
        int c = NhapSoNguyen("c");

        int max = TimMax(a, b, c);

        Console.WriteLine("Gia tri lon nhat la: " + max);
    }
}