using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3364
{
    class Karyawan
    {
        public int NIK { get; set; }
        public string nama { get; set; }
        public string gajibulanan { get; set; }
        public int no { get; set; }

        public void bulanan()
        {
            Console.WriteLine("{0}\t{1} {2}\t\t{3}", no, NIK, nama, gajibulanan);
        }

        public void kenaikan()
        {
            Console.WriteLine("{0}\t{1} {2}\t\t{3}", no, NIK, nama, gajibulanan);
        }
    }
}
