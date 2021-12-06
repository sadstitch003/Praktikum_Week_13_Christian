using System;
using System.Collections.Generic;
using System.Linq;

namespace PraktikumWeek13
{
    public class Data
    {
        public string NIM { get; set; }
        public string nama { get; set; }
        public string jenisKelamin { get; set; }
        public int tahunMasuk { get; set; }
        public string programStudi { get; set; }
        public string kelas { get; set; }
    }

    internal class Program
    {
        public static string dataNIM(List<Data> dataMahasiswa)
        {
            var dataNIM = "0";
            var adaNIMsama = true;
            while (adaNIMsama)
            {
                Console.Write("{0,-15}: ", "NIM");
                dataNIM = Console.ReadLine();
                adaNIMsama = false;
                foreach (var data in dataMahasiswa)
                    if (data.NIM == dataNIM)
                    {
                        adaNIMsama = true;
                        Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM YANG LAIN!");
                    }
            }
            return dataNIM;
        }
        public static string dataNama()
        {
            Console.Write("{0,-15}: ", "NAMA");
            return Console.ReadLine();
        }
        public static string dataJenisKelamin()
        {
            Console.Write("{0,-15}: ", "JENIS KELAMIN");
            return Console.ReadLine();
        }
        public static int dataTahunMasuk()
        {
            Console.Write("{0,-15}: ", "TAHUN MASUK");
            return Convert.ToInt16(Console.ReadLine());
        }
        public static string dataProgramStudi()
        {
            Console.Write("{0,-15}: ", "PROGRAM STUDI");
            return Console.ReadLine();
        }
        public static string dataKelas()
        {
            Console.Write("{0,-15}: ", "KELAS");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            List<Data> dataMahasiswa = new List<Data>();

            Console.Write("Berapa data = ");
            var jumlahData = Convert.ToInt16(Console.ReadLine());

            while (jumlahData > 0)
            {
                Console.WriteLine($"\ndata ke-{dataMahasiswa.Count + 1}");
                dataMahasiswa.Add(new Data()
                {
                    NIM = dataNIM(dataMahasiswa),
                    nama = dataNama(),
                    jenisKelamin = dataJenisKelamin(),
                    tahunMasuk = dataTahunMasuk(),
                    programStudi = dataProgramStudi(),
                    kelas = dataKelas()
                });

                if (jumlahData == 1)
                {
                    var cetakHasil = "0";
                    while (cetakHasil.ToLower() != "y" && cetakHasil.ToLower() !="n")
                    {
                        Console.WriteLine("\nPRINT HASIL ? (y/n) ... ");
                        cetakHasil = Console.ReadLine();
                    }

                    if (cetakHasil == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("\n{0,-5}{1,-7}{2,-25}{3,-20}{4,-20}{5,-20}{6,-10}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS");
               
                    for (int no = 0; no < dataMahasiswa.Count; no++)
                        Console.WriteLine($"{(no + 1),-5}{dataMahasiswa[no].NIM.ToUpper(),-7}{dataMahasiswa[no].nama.ToUpper(),-25}{dataMahasiswa[no].jenisKelamin.ToUpper(),-20}{dataMahasiswa[no].tahunMasuk,-20}{dataMahasiswa[no].programStudi.ToUpper(),-20}{dataMahasiswa[no].kelas.ToUpper(),-10}");
                    
                    var tambahData = "0";
                    while (tambahData.ToLower() != "y" && tambahData.ToLower() != "n")
                    {
                        Console.Write("Tambah data ? (y/n) ... ");
                        tambahData = Console.ReadLine();
                    }

                    if (tambahData.ToLower() == "y")
                    {
                        Console.Write("Berapa data ? ");
                        jumlahData += Convert.ToInt16(Console.ReadLine());
                    }
                }
            }
            jumlahData--;
        }
    }
}
}