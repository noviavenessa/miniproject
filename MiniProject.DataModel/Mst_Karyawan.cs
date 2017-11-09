namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Karyawan
    {
        public Mst_Karyawan()
        {
            Trx_Pembelian = new HashSet<Trx_Pembelian>();
            Trx_Pemesanan = new HashSet<Trx_Pemesanan>();
            Trx_Pengembalian = new HashSet<Trx_Pengembalian>();
            Trx_Penjualan = new HashSet<Trx_Penjualan>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(100)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(12)]
        public string NoHp { get; set; }

        public bool Aktif { get; set; }

        [StringLength(50)]
        public string DibuatOleh { get; set; }

        public DateTime? Dibuat { get; set; }

        [StringLength(50)]
        public string DiubahOleh { get; set; }

        public DateTime? Diubah { get; set; }

        public virtual ICollection<Trx_Pembelian> Trx_Pembelian { get; set; }

        public virtual ICollection<Trx_Pemesanan> Trx_Pemesanan { get; set; }

        public virtual ICollection<Trx_Pengembalian> Trx_Pengembalian { get; set; }

        public virtual ICollection<Trx_Penjualan> Trx_Penjualan { get; set; }
    }
}
