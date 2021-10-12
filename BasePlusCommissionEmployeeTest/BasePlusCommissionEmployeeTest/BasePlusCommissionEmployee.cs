using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
            private decimal gajiPokok;

            public BasePlusCommissionEmployee(string namaDepan, string namaBelakang, string nik, decimal penjualanKotor, decimal komisiRate, decimal gajiPokok) : base(namaDepan, namaBelakang, nik, penjualanKotor, komisiRate)
            {
                GajiPokok = gajiPokok;
            }

            public decimal GajiPokok
            {
                get
                {
                    return gajiPokok;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} must be >= 0");
                    }
                    gajiPokok = value;
                }
            }

            public override decimal Pendapatan() => GajiPokok * base.Pendapatan();
            public override string ToString() => $"Gaji pokok {base.ToString()}\nGaji Pokok: {GajiPokok:C}";
    }
}
/*public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NIK { get; }
        private decimal penjualanKotor;
        private decimal komisiRate;
        private decimal gajiPokok;

        public BasePlusCommissionEmployee(string namaDepan, string namaBelakang, string nik, decimal penjualanKotor, decimal komisiRate, decimal gajiPokok)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NIK = nik;
            PenjualanKotor = penjualanKotor;
            KomisiRate = komisiRate;
            GajiPokok = gajiPokok;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} must be >= 0");
                }
                penjualanKotor = value;
            }
        }

        public decimal KomisiRate
        {
            get
            {
                return komisiRate;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(KomisiRate)} must be >= 0");
                }
                komisiRate = value;
            }
        }

        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} must be >= 0");
                }
                gajiPokok = value;
            }
        }

        public decimal Pendapatan() => gajiPokok + (komisiRate * penjualanKotor);

        public override string ToString() =>
        $"Komisi gaji pokok pegawai: {NamaDepan} {NamaBelakang}\n" +
        $"NIK: {NIK}\n" +
        $"Penjualan kotor: {penjualanKotor:C}\n" +
        $"Komisi: {komisiRate:F2}\n" +
        $"Gaji pokok: {gajiPokok:C}";
    }*/