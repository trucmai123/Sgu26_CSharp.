using System;

static class bai03
{
    static int NhapSoNguyen(string tenBien)
    {
        Console.Write("Nhap so nguyen " + tenBien + ": ");
        return int.Parse(Console.ReadLine()!);
    }

    static void XuatKetQua(int x, int y)
    {
        int ketQua = (int)Math.Pow(x, y);
        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua);
    }

    public static void xuly()
    {
        int x = NhapSoNguyen("x");
        int y = NhapSoNguyen("y");
        XuatKetQua(x, y);
    }
}