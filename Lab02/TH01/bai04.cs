using System;

static class bai04
{
    static int NhapSoNguyen(string tenBien)
    {
        int so;
        Console.Write("Nhap so nguyen " + tenBien + ": ");

        while (!int.TryParse(Console.ReadLine(), out so))
        {
            Console.WriteLine("Loi: Ban phai nhap so nguyen!");
            Console.Write("Nhap lai so nguyen " + tenBien + ": ");
        }

        return so;
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