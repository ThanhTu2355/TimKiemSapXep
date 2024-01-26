using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemSapXep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.Write(" Cho biet so phan tu : ");
            int n = int.Parse(Console.ReadLine());

            PhatSinhMang(a, n);
            Console.WriteLine(" Mang ban dau duoc phat sinh ngau nhien : ");
            XuatMang(a, n);

            SapXepTang(a, n);
            Console.WriteLine("\n Mang duoc sap cep tang : ");
            XuatMang(a, n);

            Console.Write("\n Nhap gia tri x can tim : ");
            int x = int.Parse(Console.ReadLine());

            int kq = TimNhiPhan(a, n, x);
            if (kq == -1)
                Console.WriteLine($"{x} khong xuat hien trong mang ");
            else
                Console.WriteLine($"{x} xuat hien trong mang tai vi tri : {kq} ");

            Console.ReadLine();
        }
        static void PhatSinhMang(int[] a, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(50);
            }
        }
        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        //thuat toan tim kiem tuyen tinh
        static int TimTuyenTinh(int[] a, int n, int x)
        {
            int i = 0;
            while (i < n && a[i] != x)
                i++;
            if (i == n)
                return -1;
            else
                return i;
        }
        static int TimNhiPhan(int[] a, int n, int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                else if (a[mid] > x)
                    right = mid - 1;
                else left = mid + 1;
            }
            return -1;
        }
        static void SapXepTang(int[] a, int n)
        {
            int tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
    }
}
