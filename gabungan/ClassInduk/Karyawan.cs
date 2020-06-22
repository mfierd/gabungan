using System;
using System.Collections.Generic;

namespace tugas8
{
    class Karyawan
    {

        static void Main(string[] args)
        {
            Karyawan karyawan;

            karyawan = new KaryawanTetap();
            karyawan.Nik();
            karyawan.Nama();
            karyawan.GajiBulanan();


            karyawan = new KaryawanHarian();
            karyawan.Nik();
            karyawan.Nama();
            karyawan.JumlahJamKerja ();
            karyawan.UpahPerJam ();

            karyawan = new Sales();
            karyawan.Nik();
            karyawan.Nama();
            karyawan.JumlahPenjualan ();
            karyawan.Komisi ();

            karyawan.Gaji();
            Console.ReadKey();
        }

        public void Gaji()
        {
            throw new NotImplementedException();
        }

        public void Komisi()
        {
            throw new NotImplementedException();
        }

        public void JumlahPenjualan()
        {
            throw new NotImplementedException();
        }

        public void UpahPerJam()
        {
            throw new NotImplementedException();
        }

        public void JumlahJamKerja()
        {
            throw new NotImplementedException();
        }

        public void Nik()
        {
            Console.WriteLine("19112789");
            Console.WriteLine("19112790");
            Console.WriteLine("19112791");
        }

        public void Nama()
        {
            throw new NotImplementedException();
        }

        public void GajiBulanan()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Karyawan(KaryawanTetap v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Karyawan(KaryawanHarian v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Karyawan(Sales v)
        {
            throw new NotImplementedException();
        }
    }
}