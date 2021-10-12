using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public class PegawaiPerjam : Pegawai
    {
        private decimal upah;
        public decimal jam;

        public PegawaiPerjam(string namaDepan, string namaBelakang, string nik, decimal upahPerjam, decimal jamKerja): base(namaDepan, namaBelakang, nik)
        {
            Upah = upah;
            Jam = jam;
        }

        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Upah)} must be >= 0");
                }
                upah = value;
            }
        }

        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam)} must be >= 0 dan <= 168");
                }
                jam = value;
            }
        }
        public override decimal Pendapatan()
        {
            if (Jam <= 40)
            {
                return Upah * Jam;
            }
            else
            {
                return (40 * Upah) + ((Jam - 40) * Upah * 1.5M);
            }
        }

        public override string ToString() => $"Pegawai perjam: {base.ToString()}" +
            $"Upah perjam: {Upah:C}\nJam kerja: {Jam:F2}";
    }
}
