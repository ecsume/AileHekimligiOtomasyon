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
    public class TaniDAL : ITani
    {
        public Tani Add(Tani t)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Tanis.Add(t);
                a.SaveChanges();
                return t;
            }
        }

        public bool Delete(Tani t)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.Tanis.Find(t.TaniId);
                a.Tanis.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<Tani> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var Tanilistesi = a.Tanis.ToList();
                List<Tani> liste = new List<Tani>();
                foreach (var item in Tanilistesi)
                {
                    Tani t = new Tani();
                    t.TaniId = item.TaniId;
                    t.Aciklama = item.Aciklama;
                    liste.Add(t);
                }return liste;
            }
        }

        public Tani Update(Tani t)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(t).State = EntityState.Modified;
                a.SaveChanges();
                return t;
            }
        }
    }
}
