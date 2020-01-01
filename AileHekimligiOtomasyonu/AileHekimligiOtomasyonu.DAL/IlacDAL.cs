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
    public class IlacDAL : IIlac
    {
        public Ilac Add(Ilac i)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Ilacs.Add(i);
                a.SaveChanges();
                return i;
            }
        }

        public bool Delete(Ilac i)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.Ilacs.Find(i.IlacId);
                a.Ilacs.Remove(result);
                a.SaveChanges();
                return true;
            }

        }

        public List<Ilac> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var Ilaclistesi = a.Ilacs.ToList();
                List<Ilac> Liste = new List<Ilac>();
                foreach (var item in Ilaclistesi)
                {
                    Ilac il = new Ilac();
                    il.IlacId = item.IlacId;
                    il.IlacAdi = item.IlacAdi;
                    il.Dozaj = item.Dozaj;
                    il.KullanimSuresi = item.KullanimSuresi;
                    il.Muayenes = item.Muayenes;
                    Liste.Add(il);
                }return Liste;
            }

        }

        public Ilac Update(Ilac i)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(i).State = EntityState.Modified;
                a.SaveChanges();
                return i;
            }
        }
    }
}
