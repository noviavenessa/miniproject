namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trx_Pembelian
    {
        public Trx_Pembelian()
        {
            Trx_Pembelian_Detail = new HashSet<Trx_Pembelian_Detail>();
            Trx_Pengembalian = new HashSet<Trx_Pengembalian>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string PemasokKode { get; set; }

        [Required]
        [StringLength(10)]
        public string KaryawanKode { get; set; }

        public DateTime TglPembelian { get; set; }

        public DateTime TglSelesai { get; set; }

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

        public virtual Mst_Pemasok Mst_Suplier { get; set; }

        public virtual ICollection<Trx_Pembelian_Detail> Trx_Pembelian_Detail { get; set; }

        public virtual ICollection<Trx_Pengembalian> Trx_Pengembalian { get; set; }
    }
}
