namespace MiniProject.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TokoKonteks : DbContext
    {
        public TokoKonteks()
            : base("name=TokoKonteks")
        {
        }

        public virtual DbSet<Mst_Barang> Mst_Barang { get; set; }
        public virtual DbSet<Mst_Jenis> Mst_Jenis { get; set; }
        public virtual DbSet<Mst_Karyawan> Mst_Karyawan { get; set; }
        public virtual DbSet<Mst_Kategori> Mst_Kategori { get; set; }
        public virtual DbSet<Mst_Pelanggan> Mst_Pelanggan { get; set; }
        public virtual DbSet<Mst_Pemasok> Mst_Pemasok { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trx_Pembelian> Trx_Pembelian { get; set; }
        public virtual DbSet<Trx_Pembelian_Detail> Trx_Pembelian_Detail { get; set; }
        public virtual DbSet<Trx_Pemesanan> Trx_Pemesanan { get; set; }
        public virtual DbSet<Trx_Pemesanan_Detail> Trx_Pemesanan_Detail { get; set; }
        public virtual DbSet<Trx_Pengembalian> Trx_Pengembalian { get; set; }
        public virtual DbSet<Trx_Pengembalian_Detail> Trx_Pengembalian_Detail { get; set; }
        public virtual DbSet<Trx_Penjualan> Trx_Penjualan { get; set; }
        public virtual DbSet<Trx_Penjualan_Detail> Trx_Penjualan_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.JenisKode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.NamaBarang)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.HargaBeli)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.HargaJual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.Stok)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Barang>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Barang>()
                .HasMany(e => e.Trx_Pembelian_Detail)
                .WithRequired(e => e.Mst_Barang)
                .HasForeignKey(e => e.BarangKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Barang>()
                .HasMany(e => e.Trx_Pemesanan_Detail)
                .WithRequired(e => e.Mst_Barang)
                .HasForeignKey(e => e.BarangKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Barang>()
                .HasMany(e => e.Trx_Pengembalian_Detail)
                .WithRequired(e => e.Mst_Barang)
                .HasForeignKey(e => e.BarangKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Barang>()
                .HasMany(e => e.Trx_Penjualan_Detail)
                .WithRequired(e => e.Mst_Barang)
                .HasForeignKey(e => e.BarangKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Jenis>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Jenis>()
                .Property(e => e.KategoriKode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Jenis>()
                .Property(e => e.NamaJenis)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Jenis>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Jenis>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Jenis>()
                .HasMany(e => e.Mst_Barang)
                .WithRequired(e => e.Mst_Jenis)
                .HasForeignKey(e => e.JenisKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.NoHp)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .HasMany(e => e.Trx_Pembelian)
                .WithRequired(e => e.Mst_Karyawan)
                .HasForeignKey(e => e.KaryawanKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .HasMany(e => e.Trx_Pemesanan)
                .WithRequired(e => e.Mst_Karyawan)
                .HasForeignKey(e => e.KaryawanKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .HasMany(e => e.Trx_Pengembalian)
                .WithRequired(e => e.Mst_Karyawan)
                .HasForeignKey(e => e.KaryawanKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Karyawan>()
                .HasMany(e => e.Trx_Penjualan)
                .WithRequired(e => e.Mst_Karyawan)
                .HasForeignKey(e => e.KaryawanKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Kategori>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Kategori>()
                .Property(e => e.NamaKategori)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Kategori>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Kategori>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Kategori>()
                .HasMany(e => e.Mst_Jenis)
                .WithRequired(e => e.Mst_Kategori)
                .HasForeignKey(e => e.KategoriKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.NoHp)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .HasMany(e => e.Trx_Pemesanan)
                .WithRequired(e => e.Mst_Kostumer)
                .HasForeignKey(e => e.PelangganKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Pelanggan>()
                .HasMany(e => e.Trx_Penjualan)
                .WithRequired(e => e.Mst_Kostumer)
                .HasForeignKey(e => e.PelangganKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.Kode)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.NamaPemasok)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.NoHp)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Pemasok>()
                .HasMany(e => e.Trx_Pembelian)
                .WithRequired(e => e.Mst_Suplier)
                .HasForeignKey(e => e.PemasokKode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .Property(e => e.PemasokKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .Property(e => e.KaryawanKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .Property(e => e.Referensi)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .HasMany(e => e.Trx_Pembelian_Detail)
                .WithRequired(e => e.Trx_Pembelian)
                .HasForeignKey(e => e.PembelianId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Pembelian>()
                .HasMany(e => e.Trx_Pengembalian)
                .WithRequired(e => e.Trx_Pembelian)
                .HasForeignKey(e => e.PembelianId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.BarangKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.Harga)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pembelian_Detail>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .Property(e => e.PelangganKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .Property(e => e.KaryawanKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .Property(e => e.Referensi)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan>()
                .HasMany(e => e.Trx_Pemesanan_Detail)
                .WithRequired(e => e.Trx_Pemesanan)
                .HasForeignKey(e => e.PemesananId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.BarangKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.Harga)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pemesanan_Detail>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian>()
                .Property(e => e.KaryawanKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian>()
                .Property(e => e.Referensi)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian>()
                .HasMany(e => e.Trx_Pengembalian_Detail)
                .WithRequired(e => e.Trx_Pengembalian)
                .HasForeignKey(e => e.PengembalianId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.BarangKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.Harga)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Pengembalian_Detail>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .Property(e => e.PelangganKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .Property(e => e.KaryawanKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .Property(e => e.Referensi)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan>()
                .HasMany(e => e.Trx_Penjualan_Detail)
                .WithRequired(e => e.Trx_Penjualan)
                .HasForeignKey(e => e.PenjualanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.BarangKode)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.Harga)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.DibuatOleh)
                .IsUnicode(false);

            modelBuilder.Entity<Trx_Penjualan_Detail>()
                .Property(e => e.DiubahOleh)
                .IsUnicode(false);
        }
    }
}
