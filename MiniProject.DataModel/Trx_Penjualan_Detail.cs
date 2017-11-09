namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trx_Penjualan_Detail
    {
        public int Id { get; set; }

        public int PenjualanId { get; set; }

        [Required]
        [StringLength(10)]
        public string BarangKode { get; set; }

        public decimal Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Harga { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [StringLength(50)]
        public string DibuatOleh { get; set; }

        public DateTime? Dibuat { get; set; }

        [StringLength(50)]
        public string DiubahOleh { get; set; }

        public DateTime? Diubah { get; set; }

        public virtual Mst_Barang Mst_Barang { get; set; }

        public virtual Trx_Penjualan Trx_Penjualan { get; set; }
    }
}
