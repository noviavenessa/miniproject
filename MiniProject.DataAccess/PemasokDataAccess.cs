using MiniProject.DataModel;
using MiniProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DataAccess
{
    public class PemasokDataAccess
    {
        public static string Message = string.Empty;
        public static List<PemasokViewModel> GetAll()
        {
            List<PemasokViewModel> result = new List<PemasokViewModel>();
            using (var db = new TokoKonteks())
            {
                result = (from Pmk in db.Mst_Pemasok
                          select new PemasokViewModel
                          {
                              Id = Pmk.Id,
                              Kode = Pmk.Kode,
                              NamaPemasok = Pmk.NamaPemasok,
                              Alamat = Pmk.Alamat,
                              NoHp = Pmk.NoHp,
                              Aktif = Pmk.Aktif,
                              DibuatOleh = Pmk.DibuatOleh,
                              Dibuat = Pmk.Dibuat,
                              DiubahOleh = Pmk.DiubahOleh,
                              Diubah = Pmk.Diubah
                          }).ToList();
            }
            return result;
        }
        public static bool Update(PemasokViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new TokoKonteks())
                {
                    if (model.Id == 0)
                    {
                        Mst_Pemasok Pmk = new Mst_Pemasok();
                        Pmk.Kode = model.Kode;
                        Pmk.NamaPemasok = model.NamaPemasok;
                        Pmk.Alamat = model.Alamat;
                        Pmk.NoHp = model.NoHp;
                        Pmk.Aktif = model.Aktif;
                        Pmk.DibuatOleh = "Test";
                        Pmk.Dibuat = DateTime.Now;
                        db.Mst_Pemasok.Add(Pmk);
                        db.SaveChanges();
                    }
                    else
                    {
                        Mst_Pemasok Pmk = db.Mst_Pemasok.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (Pmk != null)
                        {
                            Pmk.Kode = model.Kode;
                            Pmk.NamaPemasok = model.NamaPemasok;
                            Pmk.Alamat = model.Alamat;
                            Pmk.NoHp = model.NoHp;
                            Pmk.Aktif = model.Aktif;
                            Pmk.DiubahOleh = "Test";
                            Pmk.Diubah = DateTime.Now;
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
        public static PemasokViewModel GetById(int id)
        {
            PemasokViewModel result = new PemasokViewModel();
            using (var db = new TokoKonteks())
            {
                result = (from Pmk in db.Mst_Pemasok
                          where Pmk.Id == id
                          select new PemasokViewModel
                          {
                              Id = Pmk.Id,
                              Kode = Pmk.Kode,
                              NamaPemasok = Pmk.NamaPemasok,
                              Alamat = Pmk.Alamat,
                              NoHp = Pmk.NoHp,
                              Aktif = Pmk.Aktif
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
                    Mst_Pemasok Pmk = db.Mst_Pemasok.Where(o => o.Id == id).FirstOrDefault();
                    if (Pmk != null)
                    {
                        db.Mst_Pemasok.Remove(Pmk);
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
