using System;

static class bai07
{
    static int NhapSoNguyen()
    {
        Console.Write("Nhap n: ");
        return int.Parse(Console.ReadLine()!);
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public static void xuly()
    {
        int n = NhapSoNguyen();

        if (LaSoNguyenTo(n))
            Console.WriteLine(n + " la so nguyen to");
        else
            Console.WriteLine(n + " khong phai la so nguyen to");
    }
}