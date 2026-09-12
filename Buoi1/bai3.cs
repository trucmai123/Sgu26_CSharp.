using System;
//cho phep su dung thu vien System

namespace buoi01 //tranh trung ten class
{
    class soSanh
    {
        public static void Main(string[] args)
        {
            //bool de dung true or false 
            bool nhoHon, lonHon, bang, lonHonBang, nhoHonBang, khac; 

            //nhap du lieu theo kieu double
            double a=double.Parse(Console.ReadLine()!);
            double b=double.Parse(Console.ReadLine()!);

            nhoHon=(a<b);
            lonHon=(a>b);
            bang=(a==b);
            lonHonBang=(a>=b);
            nhoHonBang=(a<=b);
            khac=(a!=b);

            //xuat
            Console.WriteLine("Ket qua so sanh hai so thuc {0:#,#.00} va {1:#,#.00}",a,b);
            // 0 la a, 1 la b, #,# phan cach so hang nghin, .00 hien thi hai chu so thap phan
            Console.WriteLine("{0:#,#.00}<{1:#,#.00} :{2}" ,a,b,nhoHon);
            Console.WriteLine("{0:#,#.00}>{1:#,#.00} :{2}" ,a,b,lonHon);
            Console.WriteLine("{0:#,#.00}=={1:#,#.00} :{2}" ,a,b,bang);
            Console.WriteLine("{0:#,#.00}>={1:#,#.00} :{2}" ,a,b,lonHonBang);
            Console.WriteLine("{0:#,#.00}<={1:#,#.00} :{2}" ,a,b,nhoHonBang);
            Console.WriteLine("{0:#,#.00}!={1:#,#.00} :{2}" ,a,b,khac);

            Console.Read(); //cho man hinh cho
        }
    }
}