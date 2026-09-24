using System;
using System.Collections.Generic;

static class bai17
{
    static int[,] SinhMang(int n, int m)
    {
        int[,] a = new int[n, m];
        Random rd = new Random();

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i, j] = rd.Next(10, 101);

        return a;
    }

    static void XuatMang(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(a[i, j] + "\t");

            Console.WriteLine();
        }
    }

    static void TachChanLe(int[,] a, out int[] chan, out int[] le)
    {
        List<int> dsChan = new List<int>();
        List<int> dsLe = new List<int>();

        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] % 2 == 0)
                    dsChan.Add(a[i, j]);
                else
                    dsLe.Add(a[i, j]);
            }
        }

        chan = dsChan.ToArray();
        le = dsLe.ToArray();
    }

    static void XuatMang1Chieu(int[] a)
    {
        foreach (int x in a)
            Console.Write(x + " ");

        Console.WriteLine();
    }

    public static void xuly()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap m: ");
        int m = int.Parse(Console.ReadLine()!);

        int[,] a = SinhMang(n, m);

        Console.WriteLine("\nMang A:");
        XuatMang(a);

        TachChanLe(a, out int[] chan, out int[] le);

        Console.WriteLine("\nMang chan:");
        XuatMang1Chieu(chan);

        Console.WriteLine("\nMang le:");
        XuatMang1Chieu(le);
    }
}