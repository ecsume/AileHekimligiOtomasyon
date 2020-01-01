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
    public class MuayeneDAL : IMuayene
    {
        public Muayene Add(Muayene m)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Muayenes.Add(m);
                a.SaveChanges();
                return m;
            }
        }

        public bool Delete(Muayene m)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.Muayenes.Find(m.MuayeneId);
                a.Muayenes.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<Muayene> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var Muayenelistesi = a.Muayenes.ToList();
                List<Muayene> liste = new List<Muayene>();
                foreach (var item in Muayenelistesi)
                {
                    Muayene M = new Muayene();
                    M.MuayeneId = item.MuayeneId;
                    M.Tani = item.Tani;
                    M.TaniId = item.TaniId;
                    M.Sikayet = item.Sikayet;
                    M.IlacId = item.IlacId;
                    M.Ilac = item.Ilac;
                    M.HastaId = item.HastaId;
                    M.Hasta = item.Hasta;
                    M.DoktorId = item.DoktorId;
                    M.Doktor = item.Doktor;
                    liste.Add(M);
                }return liste;
            }
        }

        public Muayene Update(Muayene m)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(m).State = EntityState.Modified;
                a.SaveChanges();
                return m;
            }
        }
    }
}
