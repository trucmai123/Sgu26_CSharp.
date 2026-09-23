using System;

static class bai02
{
    static string NhapHoTen()
    {
        Console.Write("Nhap ho ten cua ban: ");
        return Console.ReadLine()!;
    }

    static void XuatLoiChao(string hoTen)
    {
        Console.WriteLine("Chao ban " + hoTen + "!");
    }

    public static void xuly()
    {
        string hoTen = NhapHoTen();
        XuatLoiChao(hoTen);
    }
}