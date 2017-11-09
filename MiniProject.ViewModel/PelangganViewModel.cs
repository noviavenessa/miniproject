using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.ViewModel
{
    public class PelangganViewModel
    {
        public int Id { get; set; }
        public string Kode { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public bool Aktif { get; set; }
        public string DibuatOleh { get; set; }
        public DateTime? Dibuat { get; set; }
        public string DiubahOleh { get; set; }
        public DateTime? Diubah { get; set; }

    }
}
