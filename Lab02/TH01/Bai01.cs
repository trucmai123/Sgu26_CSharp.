using System;

static class bai01
{
    static string NhapHoTen()
    {
        Console.Write("Nhap ho ten: ");
        return Console.ReadLine()!;
    }

    static void XuatHoTen(string hoTen)
    {
        Console.WriteLine("Ho ten ban vua nhap: " + hoTen);
    }

    public static void xuly()
    {
        string hoTen = NhapHoTen();
        XuatHoTen(hoTen);
    }
}