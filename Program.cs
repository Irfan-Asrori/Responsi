using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3364
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan();
            Karyawan jono = new Karyawan();

            paijo.nama = "Paijo";
            paijo.NIK = 190302123;
            paijo.gajibulanan = "3,000,000";
            paijo.no = 1;

            jono.nama = "Jono";
            jono.NIK = 190302124;
            jono.gajibulanan = "2,000,000";
            jono.no = 2;

            Console.WriteLine("No\tNIK/Nama\t\tGajibulanan");
            Console.WriteLine("---------------------------------------------");

            paijo.bulanan();
            jono.bulanan();
            Console.WriteLine();
            Console.WriteLine();

            paijo.gajibulanan = "3,300,000";
            jono.gajibulanan = "2,200,000";

            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!!");
            Console.WriteLine();
            Console.WriteLine("No\tNIK/Nama\t\tGajibulanan");
            Console.WriteLine("---------------------------------------------");
            paijo.kenaikan();
            jono.kenaikan();

            Console.ReadKey();
        }
    }
}
