using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public class CommissionEmployee : Pegawai
    {
        private decimal penjualanKotor;
        private decimal komisiRate;

        public CommissionEmployee(string namaDepan, string namaBelakang, string nik, decimal penjualanKotor, decimal komisiRate) : base(namaDepan, namaBelakang, nik)
        {
            PenjualanKotor = penjualanKotor;
            KomisiRate = komisiRate;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if (value < 0)
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
                if(value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(KomisiRate)} harus > 0 dan < 1");
                }
                komisiRate = value;
            }
        }
        public override decimal Pendapatan() => KomisiRate * PenjualanKotor;
        public override string ToString() => $"Komisi pegawai: {base.ToString()}" +
        $"Penjualan kotor: {PenjualanKotor:C}\n" +
        $"Rate Komisi: {KomisiRate:F2}";
    }
}




/*

    public class CommissionEmployee
{
    public string NamaDepan { get; }
    public string NamaBelakang { get; }
    public string NIK { get; }
    private decimal penjualanKotor;
    private decimal komisiRate;

    public CommissionEmployee(string namaDepan, string namaBelakang, string nik, decimal penjualanKotor, decimal komisiRate)
    {
        NamaDepan = namaDepan;
        NamaBelakang = namaBelakang;
        NIK = nik;
        PenjualanKotor = penjualanKotor;
        KomisiRate = komisiRate;
    }

    public decimal PenjualanKotor
    {
        get
        {
            return penjualanKotor;
        }
        set
        {
            if (value < 0)
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

    public virtual decimal Pendapatan() => KomisiRate * PenjualanKotor;

    public override string ToString() =>
    $"Komisi gaji pokok pegawai: {NamaDepan} {NamaBelakang}\n" +
    $"NIK: {NIK}\n" +
    $"Penjualan kotor: {PenjualanKotor:C}\n" +
    $"Komisi: {KomisiRate:F2}\n";*/

/*public class CommissionEmployee : Pegawai
    {
        
}*/



/*public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NIK { get; }
        private decimal penjualanKotor;
        private decimal komisiRate;

        public CommissionEmployee(string namaDepan, string namaBelakang, string nik, decimal penjualanKotor, decimal komisiRate)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NIK = nik;
            PenjualanKotor = penjualanKotor;
            KomisiRate = komisiRate;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if (value < 0)
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

        public virtual decimal Pendapatan() => komisiRate * penjualanKotor;

        public override string ToString() => $"Pendapatan pegawai: {NamaDepan} {NamaBelakang}\n" +
            $"NIK: {NIK}\n" +
            $"Penjualan kotor: {penjualanKotor:C}" +
            $"Komisi: {komisiRate:F2}";*/
