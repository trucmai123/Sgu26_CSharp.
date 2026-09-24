using System;

static class bai16
{
    public static void xuly()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        string[] hoTen = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ho ten {i + 1}: ");
            hoTen[i] = Console.ReadLine()!;
        }

        Array.Sort(hoTen);

        Console.WriteLine("\nDanh sach sau khi sap xep:");

        foreach (string s in hoTen)
            Console.WriteLine(s);
    }
}