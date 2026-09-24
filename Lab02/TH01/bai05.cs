using System;

static class bai05
{
    static double x, y;
    static bool daNhap = false;

    static void NhapXY()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine()!);

        daNhap = true;
    }

    static void TinhLuyThua()
    {
        if (!daNhap)
        {
            Console.WriteLine("Vui long nhap x va y truoc!");
            return;
        }

        Console.WriteLine("x^y = " + Math.Pow(x, y));
    }

    static void TinhCanBacHai()
    {
        if (!daNhap)
        {
            Console.WriteLine("Vui long nhap x va y truoc!");
            return;
        }

        if (x >= 0)
            Console.WriteLine("Can bac 2 cua x = " + Math.Sqrt(x));
        else
            Console.WriteLine("Khong the tinh can bac 2 cua x vi x am!");

        if (y >= 0)
            Console.WriteLine("Can bac 2 cua y = " + Math.Sqrt(y));
        else
            Console.WriteLine("Khong the tinh can bac 2 cua y vi y am!");
    }

    public static void xuly()
    {
        int chon;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            switch (chon)
            {
                case 1:
                    NhapXY();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                    break;

                case 2:
                    TinhLuyThua();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                    break;

                case 3:
                    TinhCanBacHai();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Thoat chuong trinh!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                    break;
            }

        } while (chon != 4);
    }
}