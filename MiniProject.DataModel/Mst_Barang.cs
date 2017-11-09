namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Barang
    {
        public Mst_Barang()
        {
            Trx_Pembelian_Detail = new HashSet<Trx_Pembelian_Detail>();
            Trx_Pemesanan_Detail = new HashSet<Trx_Pemesanan_Detail>();
            Trx_Pengembalian_Detail = new HashSet<Trx_Pengembalian_Detail>();
            Trx_Penjualan_Detail = new HashSet<Trx_Penjualan_Detail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode { get; set; }

        [Required]
        [StringLength(10)]
        public string JenisKode { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaBarang { get; set; }

        [Column(TypeName = "money")]
        public decimal HargaBeli { get; set; }

        [Column(TypeName = "money")]
        public decimal HargaJual { get; set; }

        public decimal Stok { get; set; }

        public bool Aktif { get; set; }

        [StringLength(50)]
        public string DibuatOleh { get; set; }

        public DateTime? Dibuat { get; set; }

        [StringLength(50)]
        public string DiubahOleh { get; set; }

        public DateTime? Diubah { get; set; }

        public virtual Mst_Jenis Mst_Jenis { get; set; }

        public virtual ICollection<Trx_Pembelian_Detail> Trx_Pembelian_Detail { get; set; }

        public virtual ICollection<Trx_Pemesanan_Detail> Trx_Pemesanan_Detail { get; set; }

        public virtual ICollection<Trx_Pengembalian_Detail> Trx_Pengembalian_Detail { get; set; }

        public virtual ICollection<Trx_Penjualan_Detail> Trx_Penjualan_Detail { get; set; }
    }
}
