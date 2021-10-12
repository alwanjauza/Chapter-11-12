using System;
using System.Collections.Generic;
using System.Text;

namespace BasePlusCommissionEmployeeTest
{
    public class Invoice : IPayable
    {
        public string BagianNomor { get; }
        public string BagianDeskripsi { get; }
        private int jumlah;
        private decimal hargaPerItem;

        public Invoice(string bagianNomor, string bagianDeskripsi, int jumlah, decimal hargaPerItem)
        {
            BagianNomor = bagianNomor;
            BagianDeskripsi = bagianDeskripsi;
            Jumlah = jumlah;
            HargaPerItem = hargaPerItem;
        }
        public int Jumlah
        {
            get
            {
                return jumlah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jumlah)} must be >= 0");
                }
                jumlah = value;
            }
        }
        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerItem)} must be >= 0");
                }
                hargaPerItem = value;
            }
        }
        public override string ToString() => $"Invoice:\nPart number: {BagianNomor} ({BagianDeskripsi})\n" +
            $"Jumlah: {Jumlah}\nHarga per barang: {HargaPerItem:C}";

        public decimal JumlahPembayaran() => Jumlah * HargaPerItem;
    }
}
