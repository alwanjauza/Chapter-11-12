using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public abstract class Pegawai : IPayable
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NIK { get; }

        public Pegawai(string namaDepan, string namaBelakang, string nik)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NIK = nik;
        }

        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" +
            $"NIK: {NIK}";

        public abstract decimal Pendapatan();

        public decimal JumlahPembayaran() => Pendapatan();
    }
}
/*public abstract class Pegawai
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NIK { get; }

        public Pegawai(string namaDepan, string namaBelakang, string nik)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NIK = nik;
        }

        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" +
            $"NIK: {NIK}";

        public abstract decimal Pendapatan();
    }*/