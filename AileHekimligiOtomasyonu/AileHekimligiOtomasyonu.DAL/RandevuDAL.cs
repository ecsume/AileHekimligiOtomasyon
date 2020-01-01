using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Interface;
using AileHekimligiOtomasyonu.DAL.Entity;
using System.Data.Entity;

namespace AileHekimligiOtomasyonu.DAL
{
    public class RandevuDAL : IRandevu
    {
        public Randevu Add(Randevu r)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Randevus.Add(r);
                a.SaveChanges();
                return r;
            }
        }

        public bool Delete(Randevu r)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.Randevus.Find(r.RandevuId);
                a.Randevus.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<Randevu> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var Randevulistesi = a.Randevus.ToList();
                List<Randevu> liste = new List<Randevu>();
                foreach (var item in Randevulistesi)
                {
                    Randevu rnd = new Randevu();
                    rnd.RandevuId = item.RandevuId;
                    rnd.RandevuTarihi = item.RandevuTarihi;
                    rnd.HastaId = item.HastaId;
                    rnd.Hasta = item.Hasta;
                    rnd.Doktor = item.Doktor;
                    rnd.DoktorId=item.DoktorId;
                    liste.Add(rnd);
                }return liste;
            }

        }

        public Randevu Update(Randevu r)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(r).State = EntityState.Modified;
                a.SaveChanges();
                return r;
            }
        }
    }
}
