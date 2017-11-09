namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trx_Pengembalian
    {
        public Trx_Pengembalian()
        {
            Trx_Pengembalian_Detail = new HashSet<Trx_Pengembalian_Detail>();
        }

        public int Id { get; set; }

        public int PembelianId { get; set; }

        [Required]
        [StringLength(10)]
        public string KaryawanKode { get; set; }

        public DateTime TglReturn { get; set; }

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

        public virtual Trx_Pembelian Trx_Pembelian { get; set; }

        public virtual ICollection<Trx_Pengembalian_Detail> Trx_Pengembalian_Detail { get; set; }
    }
}
