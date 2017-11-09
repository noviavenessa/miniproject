namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trx_Penjualan
    {
        public Trx_Penjualan()
        {
            Trx_Penjualan_Detail = new HashSet<Trx_Penjualan_Detail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string PelangganKode { get; set; }

        [Required]
        [StringLength(10)]
        public string KaryawanKode { get; set; }

        public DateTime TglPenjualan { get; set; }

        [Required]
        [StringLength(10)]
        public string Referensi { get; set; }

        [StringLength(50)]
        public string DibuatOleh { get; set; }

        public DateTime? Dibuat { get; set; }

        [StringLength(50)]
        public string DiubahOleh { get; set; }

        public DateTime? Diubah { get; set; }

        public virtual Mst_Karyawan Mst_Karyawan { get; set; }

        public virtual Mst_Pelanggan Mst_Kostumer { get; set; }

        public virtual ICollection<Trx_Penjualan_Detail> Trx_Penjualan_Detail { get; set; }
    }
}
