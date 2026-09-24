using System;

static class bai10
{
    static bool KiemTraDoiXung(string s)
    {
        int trai = 0;
        int phai = s.Length - 1;

        while (trai < phai)
        {
            if (s[trai] != s[phai])
                return false;

            trai++;
            phai--;
        }

        return true;
    }

    public static void xuly()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine()!;

        if (KiemTraDoiXung(s))
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}