using System;
using System.Collections.Generic;

static class bai15
{
    static int[] NhapMang()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine()!);
        }

        return a;
    }

    static void XuatMang(int[] a)
    {
        foreach (int x in a)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    static void TimMaxMin(int[] a, out int max, out int min)
    {
        max = min = a[0];

        foreach (int x in a)
        {
            if (x > max) max = x;
            if (x < min) min = x;
        }
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;

        return true;
    }

    static int[] MangSoNguyenTo(int[] a)
    {
        List<int> ds = new List<int>();

        foreach (int x in a)
            if (LaSoNguyenTo(x))
                ds.Add(x);

        return ds.ToArray();
    }

    public static void xuly()
    {
        int[] a = NhapMang();

        Console.WriteLine("Mang:");
        XuatMang(a);

        TimMaxMin(a, out int max, out int min);

        Console.WriteLine("Max = " + max);
        Console.WriteLine("Min = " + min);

        Console.WriteLine("Mang so nguyen to:");
        XuatMang(MangSoNguyenTo(a));
    }
}