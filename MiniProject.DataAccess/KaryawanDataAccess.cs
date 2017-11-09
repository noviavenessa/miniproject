using MiniProject.DataModel;
using MiniProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DataAccess
{
    public class KaryawanDataAccess
    {
        public static string Message = string.Empty;
        public static List<KaryawanViewModel> GetAll()
        {
            List<KaryawanViewModel> result = new List<KaryawanViewModel>();
            using (var db = new TokoKonteks())
            {
                result = (from kry in db.Mst_Karyawan
                          select new KaryawanViewModel
                          {
                              Id = kry.Id,
                              Kode = kry.Kode,
                              Nama = kry.Nama,
                              Alamat = kry.Alamat,
                              NoHp = kry.NoHp,
                              Aktif = kry.Aktif,
                              DibuatOleh = kry.DibuatOleh,
                              Dibuat = kry.Dibuat,
                              DiubahOleh = kry.DiubahOleh,
                              Diubah = kry.Diubah
                          }).ToList();
            }
            return result;
        }
        public static bool Update(KaryawanViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new TokoKonteks())
                {
                    if (model.Id == 0)
                    {
                        Mst_Karyawan Kry = new Mst_Karyawan();
                        Kry.Kode = model.Kode;
                        Kry.Nama = model.Nama;
                        Kry.Alamat = model.Alamat;
                        Kry.NoHp = model.NoHp;
                        Kry.Aktif = model.Aktif;
                        Kry. DibuatOleh ="Test";
                        Kry.Dibuat = DateTime.Now;
                        db.Mst_Karyawan.Add(Kry);
                        db.SaveChanges();
                    }
                    else
                    {
                        Mst_Karyawan Kry = db.Mst_Karyawan.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (Kry != null)
                        {
                            Kry.Kode = model.Kode;
                            Kry.Nama = model.Nama;
                            Kry.Alamat = model.Alamat;
                            Kry.NoHp = model.NoHp;
                            Kry.Aktif = model.Aktif;
                            Kry.DiubahOleh = "Test";
                            Kry.Diubah = DateTime.Now;
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
        public static KaryawanViewModel GetById(int id)
        {
            KaryawanViewModel result = new KaryawanViewModel();
            using (var db = new TokoKonteks())
            {
                result = (from kry in db.Mst_Karyawan
                          where kry.Id == id
                          select new KaryawanViewModel
                          {
                              Id = kry.Id,
                              Kode = kry.Kode,
                              Nama = kry.Nama,
                              Alamat = kry.Alamat,
                              NoHp = kry.NoHp,
                              Aktif = kry.Aktif
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
                    Mst_Karyawan Kry = db.Mst_Karyawan.Where(o => o.Id == id).FirstOrDefault();
                    if (Kry != null)
                    {
                        db.Mst_Karyawan.Remove(Kry);
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
