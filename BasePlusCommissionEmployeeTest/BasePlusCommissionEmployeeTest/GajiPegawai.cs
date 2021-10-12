using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public class GajiPegawai : Pegawai
    {
        private decimal gajiMingguan;

        public GajiPegawai(string namaDepan, string namaBelakang, string nik, decimal gajiMingguan) : base(namaDepan, namaBelakang, nik)
        {
            GajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} must be >= 0");
                }
                gajiMingguan = value;
            }
        }

        public override decimal Pendapatan() => GajiMingguan;

        public override string ToString() => $"Gaji pegawai: {base.ToString()}\n" +
            $"Gaji mingguan: {GajiMingguan:C}";
    }
}
