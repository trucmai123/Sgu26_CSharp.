using System;

static class bai12
{
    public static void xuly()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine()!;

        Console.WriteLine("Chuoi thuong: " + s.ToLower());
        Console.WriteLine("Chuoi hoa: " + s.ToUpper());

        string[] tu = s.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("So tu trong chuoi: " + tu.Length);
    }
}