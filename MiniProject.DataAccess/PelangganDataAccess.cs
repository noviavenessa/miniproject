using MiniProject.DataModel;
using MiniProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DataAccess
{
    public class PelangganDataAccess
    {
        public static string Message = string.Empty;
        public static List<PelangganViewModel> GetAll()
        {
            List<PelangganViewModel> result = new List<PelangganViewModel>();
            using (var db = new TokoKonteks())
            {
                result = (from Plg in db.Mst_Pelanggan
                          select new PelangganViewModel
                          {
                              Id = Plg.Id,
                              Kode = Plg.Kode,
                              Nama = Plg.Nama,
                              Alamat = Plg.Alamat,
                              NoHp = Plg.NoHp,
                              Aktif = Plg.Aktif,
                              DibuatOleh = Plg.DibuatOleh,
                              Dibuat = Plg.Dibuat,
                              DiubahOleh = Plg.DiubahOleh,
                              Diubah = Plg.Diubah
                          }).ToList();
            }
            return result;
        }
        public static bool Update(PelangganViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new TokoKonteks())
                {
                    if (model.Id == 0)
                    {
                        Mst_Pelanggan Plg = new Mst_Pelanggan();
                        Plg.Kode = model.Kode;
                        Plg.Nama = model.Nama;
                        Plg.Alamat = model.Alamat;
                        Plg.NoHp = model.NoHp;
                        Plg.Aktif = model.Aktif;
                        Plg.DibuatOleh = "Test";
                        Plg.Dibuat = DateTime.Now;
                        db.Mst_Pelanggan.Add(Plg);
                        db.SaveChanges();
                    }
                    else
                    {
                        Mst_Pelanggan Plg = db.Mst_Pelanggan.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (Plg != null)
                        {
                            Plg.Kode = model.Kode;
                            Plg.Nama = model.Nama;
                            Plg.Alamat = model.Alamat;
                            Plg.NoHp = model.NoHp;
                            Plg.Aktif = model.Aktif;
                            Plg.DiubahOleh = "Test";
                            Plg.Diubah = DateTime.Now;
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message;
                result = false;
            }
            return result;
        }
        public static PelangganViewModel GetById(int id)
        {
            PelangganViewModel result = new PelangganViewModel();
            using (var db = new TokoKonteks())
            {
                result = (from Plg in db.Mst_Pelanggan
                          where Plg.Id == id
                          select new PelangganViewModel
                          {
                              Id = Plg.Id,
                              Kode = Plg.Kode,
                              Nama = Plg.Nama,
                              Alamat = Plg.Alamat,
                              NoHp = Plg.NoHp,
                              Aktif = Plg.Aktif
                          }).FirstOrDefault();
            }
            return result;
        }
        public static bool Delete(int id)
        {
            bool result = true;
            try
            {
                using (var db = new TokoKonteks())
                {
                    Mst_Pelanggan Kry = db.Mst_Pelanggan.Where(o => o.Id == id).FirstOrDefault();
                    if (Kry != null)
                    {
                        db.Mst_Pelanggan.Remove(Kry);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;
            }
            return result;
        }

    }
}
