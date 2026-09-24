using System;

class SinhVien
{
    public string MaSV;
    public string HoTen;
    public string DiaChi;
    public int NamHoc;

    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        MaSV = Console.ReadLine()!;

        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine()!;

        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine()!;

        Console.Write("Nhap sinh vien nam thu may: ");
        NamHoc = int.Parse(Console.ReadLine()!);
    }

    public void Xuat()
    {
        Console.WriteLine("\nTHONG TIN SINH VIEN");
        Console.WriteLine("Ma SV: " + MaSV);
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Dia chi: " + DiaChi);
        Console.WriteLine("Nam hoc: " + NamHoc);
    }
}

static class bai13
{
    public static void xuly()
    {
        SinhVien sv = new SinhVien();

        sv.Nhap();
        sv.Xuat();
    }
}