using System;

static class bai11
{
    static string DaoChuoi(string s)
    {
        char[] mang = s.ToCharArray();
        Array.Reverse(mang);
        return new string(mang);
    }

    public static void xuly()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine()!;

        Console.WriteLine("Chuoi dao: " + DaoChuoi(s));
    }
}