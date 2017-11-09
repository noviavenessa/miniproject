namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trx_Pemesanan
    {
        public Trx_Pemesanan()
        {
            Trx_Pemesanan_Detail = new HashSet<Trx_Pemesanan_Detail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string PelangganKode { get; set; }

        [Required]
        [StringLength(10)]
        public string KaryawanKode { get; set; }

        public DateTime TglPemesanan { get; set; }

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

        public virtual Mst_Pelanggan Mst_Kostumer { get; set; }

        public virtual ICollection<Trx_Pemesanan_Detail> Trx_Pemesanan_Detail { get; set; }
    }
}
