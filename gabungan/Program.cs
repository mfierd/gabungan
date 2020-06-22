using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "tugas 8";
            //objek karyawan
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19112789";
            karyawanTetap.Nama = "Bambank";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19112790";
            karyawanHarian.Nama = "Mujidin";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "19112791";
            sales.Nama = "Junaidi";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            //objek class collection

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
