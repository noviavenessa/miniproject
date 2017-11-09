namespace MiniProject.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Jenis
    {
        public Mst_Jenis()
        {
            Mst_Barang = new HashSet<Mst_Barang>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode { get; set; }

        [Required]
        [StringLength(10)]
        public string KategoriKode { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaJenis { get; set; }

        public bool Aktif { get; set; }

        [StringLength(50)]
        public string DibuatOleh { get; set; }

        public DateTime? Dibuat { get; set; }

        [StringLength(50)]
        public string DiubahOleh { get; set; }

        public DateTime? Diubah { get; set; }

        public virtual ICollection<Mst_Barang> Mst_Barang { get; set; }

        public virtual Mst_Kategori Mst_Kategori { get; set; }
    }
}
