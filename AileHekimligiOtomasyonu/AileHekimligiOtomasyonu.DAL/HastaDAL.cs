using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;
using AileHekimligiOtomasyonu.DAL.Interface;

namespace AileHekimligiOtomasyonu.DAL
{
    public class HastaDAL : IHasta
    {
        public Hasta Add(Hasta h)
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                a.Hastas.Add(h);
                a.SaveChanges();
                return h;
            }
        }

        public bool Delete(Hasta h)
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                var result = a.Hastas.Find(h.HastaId);
                a.Hastas.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<Hasta> List()
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                var Hastalistesi = a.Hastas.ToList();
                List<Hasta> liste = new List<Hasta>();
                foreach (var item in Hastalistesi)
                {
                    Hasta h = new Hasta();
                    h.HastaId = item.HastaId;
                    h.Adi = item.Adi;
                    h.Soyadi = item.Soyadi;
                    h.AnneAd = item.AnneAd;
                    h.BabaAd = item.BabaAd;
                    h.Cinsiyet = item.Cinsiyet;
                    h.DogumTarihi = item.DogumTarihi;
                    h.Email = item.Email;
                    h.Resim = item.Resim;
                    h.Randevus = item.Randevus;
                    h.Muayenes = item.Muayenes;
                    h.TcKimlik = item.TcKimlik;
                    liste.Add(h);
                } return liste;
            }
        }

        public Hasta Update(Hasta h)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(h).State = EntityState.Modified;
                a.SaveChanges();
                return h;
            }
        }
    }
}
