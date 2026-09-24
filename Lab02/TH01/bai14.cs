using System;

class NhanVien
{
    public string HoTen;
    public double MucLuong;
    public int SoNgayVang;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine()!;

        Console.Write("Nhap muc luong: ");
        MucLuong = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap so ngay vang: ");
        SoNgayVang = int.Parse(Console.ReadLine()!);
    }

    public double TinhLuong()
    {
        return MucLuong - SoNgayVang * 100000;
    }

    public void Xuat()
    {
        Console.WriteLine("\nTHONG TIN NHAN VIEN");
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Luong thuc nhan: " + TinhLuong() + " VND");
    }
}

static class bai14
{
    public static void xuly()
    {
        NhanVien nv = new NhanVien();

        nv.Nhap();
        nv.Xuat();
    }
}