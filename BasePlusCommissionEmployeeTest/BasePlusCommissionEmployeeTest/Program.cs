using System;
using System.Collections.Generic;

namespace BasePlusCommissionEmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var harusDibayar = new List<IPayable>()
            {
                new Invoice("01234", "kursi", 2, 370.00M),
                new Invoice("56789", "ban", 4, 79.975M),
                new GajiPegawai("John", "Smith", "111-11-1111", 800.00M),
                new GajiPegawai("Lisa", "Barnes", "888-88-8888", 1200.00M)}; 

            Console.WriteLine("Invoice dan Pegawai diproses secara Polymorphism:\n");

            foreach (var dapatdibayar in harusDibayar)
            {
                Console.WriteLine($"{dapatdibayar}");
                Console.WriteLine($"Jatuh tempo: {dapatdibayar.JumlahPembayaran():C}\n");
            }
            Console.ReadKey();
        }
    }
}
/*var pegawai = new BasePlusCommissionEmployee("Alwan", "Jauza", "20051214030", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Informasi pegawai obtained by properties and methods: \n");
            Console.WriteLine($"Nama depan: {pegawai.NamaDepan}");
            Console.WriteLine($"Nama belakang: {pegawai.NamaBelakang}");
            Console.WriteLine($"NIK: {pegawai.NIK}");
            Console.WriteLine($"Pendapatan kotor: {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Komisi: {pegawai.KomisiRate:F2}");
            Console.WriteLine($"Pendapatan: {pegawai.Pendapatan():C}");
            Console.WriteLine($"Gaji pokok: {pegawai.GajiPokok:C}");

            pegawai.GajiPokok = 1000.00M;

            Console.WriteLine("\nUpdate informasi pendapatan pegawai by ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Pendapatan: {pegawai.Pendapatan():C}");
            Console.ReadLine();*/



/*var commissionEmployee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Memanggil CommissionEmployee To String dan method Pendapatan " +
                "dengan base-class yang bereferensi ke base class object\n");

            Console.WriteLine(commissionEmployee.ToString());
            Console.WriteLine($"Pendapatan: {commissionEmployee.Pendapatan()}\n");

            Console.WriteLine("Memanggil BasePlusCommissionEmployee's To String dan " +
                "berasal dari class object\n");
            Console.WriteLine(basePlusCommissionEmployee.ToString());
            Console.WriteLine($"Pendapatan: {basePlusCommissionEmployee.Pendapatan()}\n");

            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
            Console.WriteLine(commissionEmployee2);
            Console.WriteLine($"Pendapatan: {basePlusCommissionEmployee.Pendapatan()}\n");
            Console.ReadLine();*/




/*var karyawanBergaji = new GajiPegawai("John", "Smith", "111-11-1111", 800.00M);
            var pegawaiPerjam = new PegawaiPerjam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);
            var komisiPegawai = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, .06M);

            Console.WriteLine("Pemrosesan karyawan secara individual:\n");

            Console.WriteLine($"{karyawanBergaji}\nDiperoleh: {karyawanBergaji.Pendapatan()}\n");
            Console.WriteLine($"{pegawaiPerjam}\nDiperoleh: {pegawaiPerjam.Pendapatan()}\n");
            Console.WriteLine($"{komisiPegawai}\nDiperoleh: {komisiPegawai.Pendapatan()}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nDiperoleh: {basePlusCommissionEmployee.Pendapatan()}\n");

            var pegawai = new List<Pegawai>() { karyawanBergaji, pegawaiPerjam, komisiPegawai, basePlusCommissionEmployee };

            Console.WriteLine("Karyawan diproses secara polymorphism:\n");

            foreach (var currentEmployee in pegawai)
            {
                Console.WriteLine(currentEmployee);

                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee)currentEmployee;

                    employee.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan 10% kenaikan: " +
                        $"{employee.GajiPokok}");
                }
                Console.WriteLine($"Diperoleh: {currentEmployee.Pendapatan():C}\n");
            }
            for (int j = 0; j < pegawai.Count; j++)
            {
                Console.WriteLine($"Pegawai {j} adalah {pegawai[j].GetType()}");
            }
            Console.ReadLine();*/