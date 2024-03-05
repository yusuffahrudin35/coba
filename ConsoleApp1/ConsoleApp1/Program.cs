using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu Calculator");
            Console.Write("\n1. Penambahan");
            Console.Write("\n1. Pengurangan");
            Console.Write("\n1. Perkalian");

            Console.WriteLine("Pilih nomor menu (1-4) :");
            int i = int.Parse(Console.ReadLine());

            if(i == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan" + a + " + " + b + " = " + penambahan(a, b));
            }
            else if (i == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}",a,b, pengurangan(a, b));

            }
            else if (i == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian  {0] * {1} = {2}",a,b, perkalian(a, b));

            }
            else if (i == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan {0} / {1} = {2}",a,b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf menu yang anda cari tidak ada");
            }
            Console.WriteLine("\nTekan sembarang untuk keluar");
            Console.ReadKey();
        }
             static int penambahan(int a, int b)
             {
                 return a + b;
             }
            static int pengurangan(int a, int b)
            {  
                 return a - b;
            }
             static int perkalian(int a, int b)
             {
                 return a * b;
             }
             static int pembagian(int a, int b)
             {
                 return a / b;
             }
    }
}
